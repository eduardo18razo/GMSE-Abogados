using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities;
using Polizas.Entities.Roles;
using Polizas.Entities.Usuarios;
using Polizas.Utils;

namespace Polizas.Administrador
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario _empleado;
        readonly BusinessRol _bRol = new BusinessRol();
        readonly BusinessUsuario _bUsuario = new BusinessUsuario();
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void CargaRoles()
        {
            try
            {
                cmbRol.DataSource = _bRol.ObtenerRoles(true);
                cmbRol.DisplayMember = "Descripcion";
                cmbRol.ValueMember = "Id";
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
            if (txtNombreUsuario.Text.Trim() == string.Empty)
            {
                txtNombreUsuario.Focus(); Mensajes.Exclamacion("Nombre de usuario es campo requerido", Text);
                return false;
            }
            if (txtPsw.Text.Trim() == string.Empty)
            {
                txtPsw.Focus(); Mensajes.Exclamacion("Contraseña es campo requerido", Text);
                return false;
            }

            if ((int)cmbRol.SelectedValue == BusinessVariables.ComboBoxCatalogo.ValueSeleccione)
            {
                cmbRol.Focus(); Mensajes.Exclamacion("Rol es campo requerido", Text);
                return false;
            }

            return true;
        }
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtNombreUsuario.Clear();
            txtPsw.Clear();
            cmbRol.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
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
                CargaRoles();
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
                    _empleado = new Usuario();
                    _empleado.Nombre = txtNombre.Text.Trim();
                    _empleado.NombreUsuario = txtNombreUsuario.Text.Trim();
                    _empleado.Password = txtPsw.Text.Trim();
                    _empleado.IdRol = ((Rol)cmbRol.SelectedItem).Id;
                }
                else
                {
                    _empleado.Nombre = txtNombre.Text.Trim();
                    _empleado.NombreUsuario = txtNombreUsuario.Text.Trim();
                    _empleado.Password = txtPsw.Text.Trim();
                    _empleado.IdRol = ((Rol)cmbRol.SelectedItem).Id;
                }

                _bUsuario.GuardarUsuario(_empleado);
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
    }
}
