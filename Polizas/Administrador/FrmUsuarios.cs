using System;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities;
using Polizas.Utils;

namespace Polizas.Administrador
{
    public partial class FrmUsuarios : Form
    {
        readonly BusinessUsuario _bUsuario = new BusinessUsuario();
        public Usuario UsuarioSeleccionado;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void ObtenerUsuarios()
        {
            try
            {
                var source =
                    _bUsuario.ObtenerRegistros(false)
                        .Select(s =>
                                new
                                {
                                    s.Id,
                                    s.Nombre,
                                    s.NombreUsuario,
                                    s.Password,
                                    Rol = s.Rol.Descripcion,
                                    Habilitado = s.Habilitado ? "Si" : "No"
                                })
                        .ToList();
                if (txtFiltroNombre.Text.Trim() != string.Empty)
                    source = source.Where(w => w.Nombre.Contains(txtFiltroNombre.Text.Trim())).ToList();
                dgvUsuarios.DataSource = source;
                dgvUsuarios.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtFiltroNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBuscar_Click(btnBuscar, null);
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //UsuarioSeleccionado = _bUsuario.ObtenerUsuario(int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString()));
                //DialogResult = DialogResult.OK;
                //Hide();
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
                
                FrmAltaUsuario frmAltaUsuario = new FrmAltaUsuario();
                frmAltaUsuario.StartPosition = FormStartPosition.CenterParent;
                frmAltaUsuario.ShowDialog(this);
                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
