using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities;

namespace Polizas.Operacion
{
    public partial class frmRegistroPersonaFisica : Form
    {
        public frmRegistroPersonaFisica()
        {
            InitializeComponent();
        }

        private bool ValidaCaptura()
        {
            bool result = true;
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Capture nombre", "Polizas Juridicas");
                txtNombre.Focus();
                result = false;
            }
            if (dpFecha.Text.Trim() == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                if (MessageBox.Show("La fecha es la misma que hoy \n¿Esta seguro?", "Polizas Juridicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    dpFecha.Focus();
                    result = false;
                }
            }
            return result;
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
                    BusinessRegistro documentManager = new BusinessRegistro();
                    documentManager.GuardarRegistro(new Registro { Nombre = txtNombre.Text.Trim(), Fecha = DateTime.Now });
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
