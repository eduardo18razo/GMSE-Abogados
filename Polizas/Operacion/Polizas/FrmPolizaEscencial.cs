using System;
using System.Windows.Forms;
using Polizas.Business.Documentos;
using Polizas.Business.Operacion;
using Polizas.Operacion.Clientes;
using Polizas.Utils;

namespace Polizas.Operacion.Polizas
{
    public partial class FrmPolizaEscencial : Form
    {
        public FrmPolizaEscencial()
        {
            InitializeComponent();
            LlenaClientes();
            LlenaEmpleados();

        }

        private void LlenaClientes()
        {
            try
            {
                cmbCliente.DataSource = new BusinessCliente().ObtenerClientes(true);
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void LlenaEmpleados()
        {
            try
            {
                cmbReferencia.DataSource = new BusinessUsuario().ObtenerUsuarios(true);
                cmbReferencia.DisplayMember = "Nombre";
                cmbReferencia.ValueMember = "Id";
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
                    //case DialogResult.Yes:
                    //    FrmRegistroPersonaFisica personaFisica = new FrmRegistroPersonaFisica();
                    //    personaFisica.EsDialog = true;
                    //    personaFisica.StartPosition = FormStartPosition.CenterParent;
                    //    if (personaFisica.ShowDialog(this) == DialogResult.OK)
                    //    {
                    //        LLenaClientes();
                    //    }
                    //    break;
                    //case DialogResult.No:
                    //    FrmRegistroPersonaMoral personaMoral = new FrmRegistroPersonaMoral();
                    //    personaMoral.EsDialog = true;
                    //    personaMoral.StartPosition = FormStartPosition.CenterParent;
                    //    personaMoral.ShowDialog();
                    //    if (personaMoral.ShowDialog(this) == DialogResult.OK)
                    //    {
                    //        LLenaClientes();
                    //    }
                    //    break;
                    //case DialogResult.Cancel:
                    //    return;
                    //    break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnGenerarDocumentos_Click(object sender, EventArgs e)
        {
            try
            {
                new AutorizacionBuroCredito().GeneraDocumento(int.Parse(cmbCliente.SelectedValue.ToString()), dateTimePicker1.Value);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
