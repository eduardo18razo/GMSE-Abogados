using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Business.Operacion;
using Polizas.Entities.Clientes;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmConsultaRegistros : Form
    {
        private readonly BusinessCliente _bRegistro = new BusinessCliente();
        public FrmConsultaRegistros()
        {
            InitializeComponent();
        }

        private void LLenaRegistros()
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                List<Cliente> lstRegistros = string.IsNullOrEmpty(filtro) ? _bRegistro.ObtenerClientes(false) : _bRegistro.BuscarClientes(filtro);
                dgvRegistros.DataSource = lstRegistros.Select(s => new { s.Id, s.Nombre, s.Correo, s.FechaAlta }).ToList();
                dgvRegistros.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void FrmConsultaRegistros_Load(object sender, EventArgs e)
        {
            try
            {
                LLenaRegistros();
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
                LLenaRegistros();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    LLenaRegistros();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idRegistro = int.Parse(dgvRegistros.Rows[e.RowIndex].Cells[0].Value.ToString());
                FrmDetalleRegistro frmDetalle = new FrmDetalleRegistro(idRegistro);
                frmDetalle.MdiParent = this.MdiParent;
                frmDetalle.StartPosition = FormStartPosition.CenterParent;
                frmDetalle.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        
    }
}
