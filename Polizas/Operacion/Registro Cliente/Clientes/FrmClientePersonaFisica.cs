using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business.Operacion;
using Polizas.Entities.Clientes;
using Polizas.Entities.Helpers;
using Polizas.Entities.Inmueble;
using Polizas.Operacion.Genericos;
using Polizas.Utils;

namespace Polizas.Operacion.Clientes
{
    public partial class FrmClientePersonaFisica : Form
    {
        public FrmClientePersonaFisica()
        {
            InitializeComponent();
        }
        public bool EsDialog { get; set; }
        private bool ValidaCaptura()
        {
            if (txtExpediente.Text.Trim() == string.Empty)
            {
                Mensajes.Exclamacion("Capture Número de contrato");
                txtExpediente.Focus();
                return false;
            }
            if (chkActividadEmpresarial.CheckState == CheckState.Indeterminate)
            {
                Mensajes.Exclamacion("especifique si cuenta con actividad empresarial");
                chkActividadEmpresarial.Focus();
                return false;
            }
            if (txtNombre.Text.Trim() == string.Empty)
            {
                Mensajes.Exclamacion("Capture nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtCorreo.Text.Trim() == string.Empty)
            {
                Mensajes.Exclamacion("Capture correo");
                txtCorreo.Focus();
                return false;
            }
            if (txtRepLegal.Text.Trim() != string.Empty)
            {
                if (txtRfc.Text.Trim() == string.Empty)
                {
                    Mensajes.Exclamacion("Capture R.F.C.");
                    txtRfc.Focus();
                    return false;
                }
            }
            if (!ucDireccion1.ValidaCaptura())
                return false;
            return true;
        }
        private List<HelperTelefonos> Telefonos { get; set; }
        private List<HelperInmueble> Inmuebles { get; set; }

        private void LlenaTelefonos()
        {
            try
            {
                dgvTelefonos.DataSource = dgvTelefonos.DataSource != null ? null : Telefonos;
                dgvTelefonos.DataSource = Telefonos;
                dgvTelefonos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void LlenaInmuebles()
        {
            try
            {
                dgvInmuebles.DataSource = dgvInmuebles.DataSource != null ? null : Inmuebles;
                dgvInmuebles.DataSource = Inmuebles;
                dgvInmuebles.Columns[0].Visible = false;
                dgvInmuebles.Columns[2].Visible = false;
                dgvInmuebles.Columns[7].Visible = false;
                dgvInmuebles.Columns[14].Visible = false;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCaptura())
                {
                    BusinessCliente documentManager = new BusinessCliente();
                    Cliente cte = new Cliente
                    {
                        NoContrato = txtExpediente.Text,
                        Nombre = txtNombre.Text,
                        PersonaFisica = true,
                        ActividadEmpresarial = chkActividadEmpresarial.Checked,
                        RepresentanteLegal = txtRepLegal.Text,
                        Rfc = txtRfc.Text,
                        Correo = txtCorreo.Text,
                        //TODO: Referenciar a pantalla
                        //IdUsuarioReferencia= Properties.Settings.userData.Id,


                    };
                    if (ucDireccion1.Direccion != null)
                        cte.ClienteDireccion = new List<ClienteDireccion>
                        {
                            new ClienteDireccion
                            {
                                Calle = ucDireccion1.Direccion.Calle,
                                IdColonia = ucDireccion1.Direccion.IdColonia,
                                NoExt = ucDireccion1.Direccion.NoExt,
                                NoInt = ucDireccion1.Direccion.NoInt
                            }
                        };
                    if (Telefonos != null && Telefonos.Count > 0)
                    {
                        cte.ClienteTelefono = new List<ClienteTelefono>();
                        foreach (HelperTelefonos telefono in Telefonos)
                        {
                            cte.ClienteTelefono.Add(new ClienteTelefono
                            {
                                IdTipoTelefono = telefono.IdTipoTelefono,
                                Telefono = telefono.Numero,
                                Extensiones = telefono.Extension,
                            });
                        }
                    }
                    if (Inmuebles != null && Inmuebles.Count > 0)
                    {
                        cte.InmuebleCliente = new List<InmuebleCliente>();
                        foreach (HelperInmueble inmueble in Inmuebles)
                        {
                            cte.InmuebleCliente.Add(new InmuebleCliente
                            {
                                IdTipoInmueble = inmueble.IdTipoInmueble,
                                IdTipoUso = inmueble.IdTipoUso,
                                Calle = inmueble.Calle,
                                NoExt = inmueble.NoExt,
                                NoInt = inmueble.NoInt,
                                IdColonia = inmueble.IdColonia,
                                Renta = inmueble.Renta,
                                Mantenimiento = inmueble.Mantenimiento,
                                NumeroDepositos = inmueble.NumeroDepositos,
                                CantidadDepositos = inmueble.Renta * inmueble.NumeroDepositos,
                                Habilitado = true,
                            });
                        }
                    }
                    documentManager.GuardarCliente(cte);
                    if (EsDialog)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaTelefono altaTelefono = new FrmAltaTelefono();
                altaTelefono.StartPosition = FormStartPosition.CenterParent;
                if (altaTelefono.ShowDialog(this) == DialogResult.OK)
                {
                    if (Telefonos == null)
                        Telefonos = new List<HelperTelefonos>();
                    Telefonos.Add(altaTelefono.Telefono);
                    LlenaTelefonos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminarTelefono_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTelefonos.CurrentRow != null)
                {
                    int idTipoTelefono = int.Parse(dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[0].Value.ToString());
                    string numero = dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[2].Value.ToString();
                    string extension = dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[3].Value.ToString();
                    Telefonos.RemoveAll(i => i.IdTipoTelefono == idTipoTelefono && i.Numero == numero && i.Extension == extension);
                    LlenaTelefonos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAgregarInmueble_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaInmueble altaInmueble = new FrmAltaInmueble();
                altaInmueble.StartPosition = FormStartPosition.CenterParent;
                if (altaInmueble.ShowDialog(this) == DialogResult.OK)
                {
                    if (Inmuebles == null)
                        Inmuebles = new List<HelperInmueble>();
                    Inmuebles.Add(altaInmueble.Inmueble);
                    LlenaInmuebles();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btneliminarInmueble_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInmuebles.CurrentRow != null)
                {
                    string calle = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[4].Value.ToString();
                    string noext = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[5].Value.ToString();
                    string noint = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[6].Value.ToString();
                    int idCol = int.Parse(dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[7].Value.ToString());
                    Inmuebles.RemoveAll(i => i.Calle == calle && i.NoExt == noext && i.NoInt == noint && i.IdColonia == idCol);
                    LlenaInmuebles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTelefonos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvTelefonos.CurrentRow != null)
                {
                    int idTipoTelefono = int.Parse(dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[0].Value.ToString());
                    string numero = dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[2].Value.ToString();
                    string extension = dgvTelefonos.Rows[dgvTelefonos.CurrentRow.Index].Cells[3].Value.ToString();
                    FrmAltaTelefono altaTelefono = new FrmAltaTelefono();
                    altaTelefono.StartPosition = FormStartPosition.CenterParent;
                    altaTelefono.Telefono = Telefonos.SingleOrDefault(i => i.IdTipoTelefono == idTipoTelefono && i.Numero == numero && i.Extension == extension);
                    if (altaTelefono.Telefono != null)
                    {
                        if (altaTelefono.ShowDialog(this) == DialogResult.OK)
                        {
                            foreach (HelperTelefonos telefono in Telefonos)
                            {
                                if (telefono.IdTipoTelefono == idTipoTelefono && telefono.Numero == numero && telefono.Extension == extension)
                                {
                                    telefono.IdTipoTelefono = altaTelefono.Telefono.IdTipoTelefono;
                                    telefono.TipoTelefono = altaTelefono.Telefono.TipoTelefono;
                                    telefono.Numero = altaTelefono.Telefono.Numero;
                                    telefono.Extension = altaTelefono.Telefono.Extension;
                                    break;
                                }
                            }

                            LlenaTelefonos();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInmuebles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInmuebles.CurrentRow != null)
                {
                    string calle = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[4].Value.ToString();
                    string noext = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[5].Value.ToString();
                    string noint = dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[6].Value.ToString();
                    int idCol = int.Parse(dgvInmuebles.Rows[dgvInmuebles.CurrentRow.Index].Cells[7].Value.ToString());
                    FrmAltaInmueble altaInmueble = new FrmAltaInmueble();
                    altaInmueble.StartPosition = FormStartPosition.CenterParent;
                    altaInmueble.Inmueble = Inmuebles.SingleOrDefault(i => i.Calle == calle && i.NoExt == noext && i.NoInt == noint && i.IdColonia == idCol);

                    if (altaInmueble.ShowDialog(this) == DialogResult.OK)
                    {
                        var inm = altaInmueble.Inmueble;
                        foreach (HelperInmueble inmueble in Inmuebles)
                        {
                            if (inmueble.Calle != calle || inmueble.NoExt != noext || inmueble.NoInt != noint || inmueble.IdColonia != idCol) continue;
                            inmueble.IdTipoInmueble = inm.IdTipoInmueble;
                            inmueble.TipoInmueble = inm.TipoInmueble;
                            inmueble.IdTipoUso = inm.IdTipoUso;
                            inmueble.UsoSuelo = inm.UsoSuelo;
                            inmueble.Calle = inm.Calle;
                            inmueble.NoExt = inm.NoExt;
                            inmueble.NoInt = inm.NoInt;
                            inmueble.IdColonia = inm.IdColonia;
                            inmueble.Renta = inm.Renta;
                            inmueble.Mantenimiento = inm.Mantenimiento;
                            inmueble.NumeroDepositos = inm.NumeroDepositos;
                            break;
                        }
                        LlenaInmuebles();
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
