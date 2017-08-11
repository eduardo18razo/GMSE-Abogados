using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities.Helpers;
using Polizas.Utils;

namespace Polizas.Administrador
{
    public partial class UcTelefonos : UserControl
    {
        readonly BusinessTipoTelefono _bTipoTelefono = new BusinessTipoTelefono();

        public UcTelefonos()
        {
            InitializeComponent();
        }

        private void LlenaTipoTelefono()
        {
            try
            {
                cmbTipo.DataSource = _bTipoTelefono.ObtenerTiposTelefono(true);
                cmbTipo.DisplayMember = "Descripcion";
                cmbTipo.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<HelperTelefonos> Telefonos { get; set; }

        private void LimpiaControles()
        {
            try
            {
                cmbTipo.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                txtNumero.Text = string.Empty;
                txtExtension.Text = string.Empty;
                gvTelefonos.DataSource = null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void LlenaTelefonos()
        {
            try
            {
                gvTelefonos.DataSource = Telefonos;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private bool ValidaCaptura()
        {
            try
            {
                if (cmbTipo.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbTipo.Focus();
                    throw new Exception("seleccione Tipo de Telefono");
                }
                if (txtNumero.Text.Trim() == string.Empty)
                {
                    txtNumero.Focus();
                    throw new Exception("IngreseNumero de telefono");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCaptura())
                {
                    HelperTelefonos ht = new HelperTelefonos();
                    ht.IdTipoTelefono = int.Parse(cmbTipo.SelectedValue.ToString());
                    ht.TipoTelefono = cmbTipo.Text;
                    ht.Numero = txtNumero.Text.Trim();
                    ht.Extension = txtExtension.Text.Trim();
                    if (Telefonos == null)
                        Telefonos = new List<HelperTelefonos>();
                    Telefonos.Add(ht);
                    LimpiaControles();
                    LlenaTelefonos();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UcTelefonos_Load(object sender, EventArgs e)
        {
            try
            {
                LlenaTipoTelefono();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void gvTelefonos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
