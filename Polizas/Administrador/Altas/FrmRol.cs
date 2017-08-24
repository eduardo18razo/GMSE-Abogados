using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities.Roles;
using Polizas.Utils;

namespace Polizas.Administrador.Altas
{
    public partial class FrmRol : Form
    {
        readonly BusinessRol _bRol = new BusinessRol();
        private bool _actualizar;
        private Rol _rol;
        public FrmRol()
        {
            InitializeComponent();
        }

        private void LLenaRoles()
        {
            try
            {
                gvRoles.DataSource = _bRol.ObtenerRoles(false);
                gvRoles.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void Limpiar()
        {
            try
            {
                txtDescripcion.Text = string.Empty;
                _actualizar = false;
                _rol = null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            try
            {
                LLenaRoles();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtDescripcion.Text.Trim() == string.Empty)
                    throw new Exception("Descripcion es campo requerido.");
                if (_rol == null)
                    _rol = new Rol();
                _rol.Descripcion = txtDescripcion.Text.Trim();
                if (_actualizar)
                    _bRol.Actualizar(_rol);
                else
                    _bRol.CrearRol(_rol);
                LLenaRoles();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }

        }

        private void gvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(gvRoles.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                _rol= _bRol.ObtenerRol(id);
                txtDescripcion.Text = _rol.Descripcion;
                _actualizar = true;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
