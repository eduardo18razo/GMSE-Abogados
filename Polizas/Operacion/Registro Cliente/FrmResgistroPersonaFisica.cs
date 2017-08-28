using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Business.Operacion;
using Polizas.Entities.Clientes;
using Polizas.Entities.Helpers;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmRegistroPersonaFisica : Form
    {
        public FrmRegistroPersonaFisica()
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    if (ucTelefonos.Telefonos != null && ucTelefonos.Telefonos.Count > 0)
                    {
                        cte.ClienteTelefono = new List<ClienteTelefono>();
                        foreach (HelperTelefonos telefono in ucTelefonos.Telefonos)
                        {
                            cte.ClienteTelefono.Add(new ClienteTelefono
                            {
                                IdTipoTelefono = telefono.IdTipoTelefono,
                                Telefono = telefono.Numero,
                                Extensiones = telefono.Extension,
                            });
                        }
                    }
                    documentManager.GuardarCliente(cte);
                    if (EsDialog)
                    {
                        this.DialogResult = DialogResult.OK;
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
    }
}
