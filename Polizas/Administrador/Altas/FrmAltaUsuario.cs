using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Business.Catalogos;
using Polizas.Business.Manager;
using Polizas.Business.Operacion;
using Polizas.Entities.Helpers;
using Polizas.Entities.Roles;
using Polizas.Entities.Usuarios;
using Polizas.Utils;

namespace Polizas.Administrador.Altas
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario _empleado;
        readonly BusinessPuesto _bPuesto = new BusinessPuesto();
        readonly BusinessRol _bRol = new BusinessRol();
        readonly BusinessUsuario _bUsuario = new BusinessUsuario();
        public FrmAltaUsuario()
        {
            InitializeComponent();
            CargaRoles();
            CargaPuestos();
        }

        public Usuario Usuario
        {
            set
            {
                _empleado = value;
                txtNombre.Text = _empleado.Nombre;
                txtCorreo.Text = _empleado.Correo;
                cmbPuesto.SelectedValue = _empleado.IdPuesto;
                txtNombreUsuario.Text = _empleado.NombreUsuario;
                txtPsw.Text = _empleado.Password;
                foreach (UsuarioRol item in _empleado.UsuarioRol)
                {
                    for (int i = 0; i < chkLbxRoles.Items.Count; i++)
                    {
                        if (((Rol)chkLbxRoles.Items[i]).Id == item.IdRol)
                        {
                            chkLbxRoles.SetItemChecked(i, true);
                        }
                    }
                    //item.Checked = _empleado.UsuarioRol.Any(a=>a.IdRol == item)
                }
                HelperDireccion hDireccion = new HelperDireccion();
                if (_empleado.UsuarioDireccion.Count > 0)
                {
                    hDireccion.IdColonia = _empleado.UsuarioDireccion.First().IdColonia;
                    hDireccion.Cp = _empleado.UsuarioDireccion.First().Colonia.CP;
                    hDireccion.Calle = _empleado.UsuarioDireccion.First().Calle;
                    hDireccion.NoExt = _empleado.UsuarioDireccion.First().NoExt;
                    hDireccion.NoInt = _empleado.UsuarioDireccion.First().NoInt;
                    ucDireccion.Direccion = hDireccion;
                }

                List<HelperTelefonos> telefonos = new List<HelperTelefonos>();
                foreach (UsuarioTelefono telefono in _empleado.UsuarioTelefono)
                {
                    HelperTelefonos ht = new HelperTelefonos();
                    ht.IdTipoTelefono = telefono.IdTipoTelefono;
                    ht.TipoTelefono = telefono.TipoTelefono.Descripcion;
                    ht.Numero = telefono.Telefono;
                    ht.Extension = telefono.Extension;
                    telefonos.Add(ht);
                }

                ucTelefonos.Telefonos = telefonos;
                ucTelefonos.LlenaTelefonos();
            }
        }

        private void CargaRoles()
        {
            try
            {
                chkLbxRoles.DataSource = _bRol.ObtenerRoles(false);
                chkLbxRoles.DisplayMember = "Descripcion";
                chkLbxRoles.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void CargaPuestos()
        {
            try
            {
                cmbPuesto.DataSource = _bPuesto.ObtenerPuestos(true);
                cmbPuesto.DisplayMember = "Descripcion";
                cmbPuesto.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private bool ValidaControles()
        {
            if (txtNombre.Text.Trim() == string.Empty)
            {
                txtNombre.Focus();
                Mensajes.Exclamacion("Nombre es campo requerido", Text);
                return false;
            }
            if (cmbPuesto.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
            {
                cmbPuesto.Focus();
                Mensajes.Exclamacion("Seleccione un puesto.");
                return false;
            }
            if (txtCorreo.Text.Trim() == string.Empty)
            {
                txtCorreo.Focus(); Mensajes.Exclamacion("Correo es campo requerido", Text);
                return false;
            }
            if (txtNombreUsuario.Text.Trim() == string.Empty)
            {
                txtNombreUsuario.Focus(); Mensajes.Exclamacion("Nombre de usuario es campo requerido", Text);
                return false;
            }
            if (txtPsw.Text.Trim() == string.Empty)
            {
                txtPsw.Focus(); Mensajes.Exclamacion("Contraseña es campo requerido.", Text);
                return false;
            }

            if (chkLbxRoles.SelectedItems.Count <= 0)
            {
                chkLbxRoles.Focus(); Mensajes.Exclamacion("Seleccione por lo menos un rol.", Text);
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtPsw.Clear();
            //cmbRol.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
            _empleado = null;
            HabilitarControles(true);
        }

        private void HabilitarControles(bool enabled)
        {
            txtPsw.Enabled = enabled;
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidaControles()) return;
            bool nuevo = _empleado == null;
            try
            {

                if (nuevo)
                {
                    _empleado = new Usuario
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Correo = txtCorreo.Text.Trim(),
                        IdPuesto = int.Parse(cmbPuesto.SelectedValue.ToString()),
                        NombreUsuario = txtNombreUsuario.Text.Trim(),
                        Password = txtPsw.Text.Trim(),
                        UsuarioRol = new List<UsuarioRol>()
                    };
                    List<Rol> selected = chkLbxRoles.SelectedItems.Cast<Rol>().ToList();
                    foreach (Rol item in selected)
                    {
                        _empleado.UsuarioRol.Add(new UsuarioRol { IdRol = item.Id });
                    }
                    _empleado.UsuarioDireccion = new List<UsuarioDireccion>
                    {
                        new UsuarioDireccion
                        {
                            Calle = ucDireccion.Direccion.Calle,
                            IdColonia = ucDireccion.Direccion.IdColonia,
                            NoExt = ucDireccion.Direccion.NoExt,
                            NoInt = ucDireccion.Direccion.NoInt
                        }
                    };
                    _empleado.UsuarioTelefono = new List<UsuarioTelefono>();
                    foreach (HelperTelefonos telefono in ucTelefonos.Telefonos)
                    {
                        _empleado.UsuarioTelefono.Add(new UsuarioTelefono
                        {
                            IdTipoTelefono = telefono.IdTipoTelefono,
                            Telefono = telefono.Numero,
                            Extension = telefono.Extension,
                            Principal = false
                        });
                    }
                }
                else
                {
                    _empleado.Nombre = txtNombre.Text.Trim();
                    _empleado.Correo = txtCorreo.Text.Trim();
                    _empleado.IdPuesto = int.Parse(cmbPuesto.SelectedValue.ToString());
                    _empleado.NombreUsuario = txtNombreUsuario.Text.Trim();
                    _empleado.Password = txtPsw.Text.Trim();
                    _empleado.UsuarioRol = new List<UsuarioRol>();
                    List<Rol> selected = chkLbxRoles.SelectedItems.Cast<Rol>().ToList();
                    foreach (Rol item in selected)
                    {
                        _empleado.UsuarioRol.Add(new UsuarioRol { IdRol = item.Id });
                    }
                    _empleado.UsuarioDireccion = new List<UsuarioDireccion>
                    {
                        new UsuarioDireccion
                        {
                            Calle = ucDireccion.Direccion.Calle,
                            IdColonia = ucDireccion.Direccion.IdColonia,
                            NoExt = ucDireccion.Direccion.NoExt,
                            NoInt = ucDireccion.Direccion.NoInt
                        }
                    };
                    _empleado.UsuarioTelefono = new List<UsuarioTelefono>();
                    foreach (HelperTelefonos telefono in ucTelefonos.Telefonos)
                    {
                        _empleado.UsuarioTelefono.Add(new UsuarioTelefono
                        {
                            IdTipoTelefono = telefono.IdTipoTelefono,
                            Telefono = telefono.Numero,
                            Extension = telefono.Extension,
                            Principal = false
                        });
                    }
                }

                if (nuevo)
                    _bUsuario.Guardar(_empleado);
                else
                    _bUsuario.Actualizar(_empleado);
                LimpiarControles();
                Mensajes.Exito(Text);
                Close();
            }
            catch (Exception ex)
            {
                if (nuevo)
                    _empleado = null;
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaPuesto frmPuesto = new FrmAltaPuesto();
                frmPuesto.StartPosition = FormStartPosition.CenterParent;
                if (frmPuesto.ShowDialog(this) == DialogResult.OK)
                {
                    CargaPuestos();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
