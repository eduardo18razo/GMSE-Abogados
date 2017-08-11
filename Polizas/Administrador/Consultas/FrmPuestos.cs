using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polizas.Administrador.Altas;
using Polizas.Business;
using Polizas.Utils;

namespace Polizas.Administrador.Consultas
{
    public partial class FrmPuestos : Form
    {
        BusinessPuesto _bPuestos = new BusinessPuesto();
        public FrmPuestos()
        {
            InitializeComponent();
        }

        private void CargaPuestos()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                gvPuestos.DataSource = _bPuestos.ObtenerPuestos(false);
                gvPuestos.Columns[0].Visible = false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            try
            {
                CargaPuestos();
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
                FrmAltaPuesto frmAlta = new FrmAltaPuesto();
                frmAlta.StartPosition = FormStartPosition.CenterParent;
                if (frmAlta.ShowDialog(this) == DialogResult.OK)
                {
                    CargaPuestos();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void gvPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmAltaPuesto frmAlta = new FrmAltaPuesto { Puesto = _bPuestos.ObtenerPuestoById(int.Parse(gvPuestos.Rows[e.RowIndex].Cells[0].Value.ToString())) };
                if (frmAlta.ShowDialog(this) == DialogResult.OK)
                {
                    CargaPuestos();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        
    }
}
