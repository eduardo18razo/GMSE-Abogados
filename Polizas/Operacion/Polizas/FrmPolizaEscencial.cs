using System;
using System.Windows.Forms;
using Polizas.Utils;

namespace Polizas.Operacion.Polizas
{
    public partial class FrmPolizaEscencial : Form
    {
        public FrmPolizaEscencial()
        {
            InitializeComponent();
        }

        private void LLenaClientes()
        {
            try
            {
                cmbCliente.DataSource = new Business.BusinessCliente().ObtenerClientes(true);
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void FrmPolizaEscencial_Load(object sender, EventArgs e)
        {
            try
            {
                LLenaClientes();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTipoCliente tipoCliente = new FrmTipoCliente();
                tipoCliente.StartPosition = FormStartPosition.CenterParent;
                DialogResult result = tipoCliente.ShowDialog(this);
                switch (result)
                {
                    case DialogResult.Yes:
                        FrmRegistroPersonaFisica personaFisica = new FrmRegistroPersonaFisica();
                        personaFisica.EsDialog = true;
                        personaFisica.StartPosition = FormStartPosition.CenterParent;
                        if (personaFisica.ShowDialog(this) == DialogResult.OK)
                        {
                            LLenaClientes();
                        }
                        break;
                    case DialogResult.No:
                        FrmRegistroPersonaMoral personaMoral = new FrmRegistroPersonaMoral();
                        personaMoral.EsDialog = true;
                        personaMoral.StartPosition = FormStartPosition.CenterParent;
                        personaMoral.ShowDialog();
                        if (personaMoral.ShowDialog(this) == DialogResult.OK)
                        {
                            LLenaClientes();
                        }
                        break;
                    case DialogResult.Cancel:
                        return;
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
