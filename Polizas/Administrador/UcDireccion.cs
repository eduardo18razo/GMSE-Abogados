using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities.Helpers;
using Polizas.Utils;

namespace Polizas.Administrador
{
    public partial class UcDireccion : UserControl
    {
        BusinessColonia _bColonia = new BusinessColonia();
        public UcDireccion()
        {
            InitializeComponent();
        }

        public HelperDireccion Direccion
        {
            get
            {
                return new HelperDireccion
                {
                    IdColonia = int.Parse(cmbColonia.SelectedValue.ToString()),
                    Cp = int.Parse(txtCp.Text.Trim()),
                    Calle = txtCalle.Text.Trim(),
                    NoExt = txtNoExt.Text.Trim(),
                    NoInt = txtNoInt.Text.Trim()
                };
            }
            set
            {
                txtCp.Text = value.Cp.ToString();
                LlenaColonias();
                cmbColonia.SelectedValue = value.IdColonia;
                txtCalle.Text = value.Calle;
                txtNoExt.Text = value.NoExt;
                txtNoInt.Text = value.NoInt;
            }
        }

        public bool ValidaCaptura()
        {
            try
            {
                if (txtCp.Text.Trim() == string.Empty)
                {
                    txtCp.Focus();
                    throw new Exception("Ingrese un codigo postal valido");
                }
                if (cmbColonia.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    txtCp.Focus();
                    throw new Exception("Ingrese un codigo postal valido");
                }
                if (txtCalle.Text.Trim() == string.Empty)
                {
                    txtCalle.Focus();
                    throw new Exception("Ingrese Calle");
                }
                if (txtNoExt.Text.Trim() == string.Empty)
                {
                    txtNoExt.Focus();
                    throw new Exception("Ingrese Numero exterior");
                }
                //if (txtNoInt.Text.Trim() == string.Empty)
                //{
                //    txtCalle.Focus();
                //    throw new Exception("Ingrese Calle");
                //}
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        private void LlenaColonias()
        {
            try
            {
                if (txtCp.Text.Trim() == string.Empty)
                    throw new Exception("Ingrese un codigo postal valido.");
                int cp = int.Parse(txtCp.Text.Trim());
                cmbColonia.DataSource = _bColonia.ObtenerColoniasCp(cp, true);
                cmbColonia.DisplayMember = "Descripcion";
                cmbColonia.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtCp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LlenaColonias();
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtNoExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                //// only allow one decimal point
                //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                //{
                //    e.Handled = true;
                //}
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtNoInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                //// only allow one decimal point
                //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                //{
                //    e.Handled = true;
                //}
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
