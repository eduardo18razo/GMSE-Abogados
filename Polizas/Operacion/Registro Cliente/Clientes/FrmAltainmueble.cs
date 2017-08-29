using System;
using System.Windows.Forms;
using Polizas.Business.Catalogos;
using Polizas.Business.Manager;
using Polizas.Entities.Helpers;
using Polizas.Entities.Ubicacion;
using Polizas.Utils;

namespace Polizas.Operacion.Clientes
{
    public partial class FrmAltainmueble : Form
    {
        private readonly  BusinessColonia _bColonia = new BusinessColonia();
        public FrmAltainmueble()
        {
            InitializeComponent();
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

        public HelperInmueble Inmueble
        {
            get
            {

                HelperInmueble result = new HelperInmueble
                {
                    IdTipoInmueble = int.Parse(cmbTipoInmueble.SelectedValue.ToString()),
                    IdTipoUso = int.Parse(cmbUsoSuelo.SelectedValue.ToString()),
                    Calle = txtCalle.Text.Trim(),
                    NoExt = txtNoExt.Text.Trim(),
                    NoInt = txtNoInt.Text.Trim(),
                    IdColonia = int.Parse(cmbColonia.SelectedValue.ToString()),
                    Renta = decimal.Parse(txtRenta.Text),
                    Mantenimiento = decimal.Parse(txtMantenimiento.Text),
                    CantidadDepositos = decimal.Parse(txtDepositosRequeridos.Text),
                    NumeroDepositos = decimal.Parse(txtDepositosRequeridos.Text),
                };
                return result;
            }
            set
            {
                cmbTipoInmueble.SelectedValue = value.IdTipoInmueble;
                cmbUsoSuelo.SelectedValue = value.IdTipoUso;
                txtCalle.Text = value.Calle;
                txtNoExt.Text = value.NoExt;
                txtNoInt.Text = value.NoInt;
                Colonia col = _bColonia.ObtenerColonia(value.IdColonia);
                txtCp.Text = col != null ? col.CP.ToString() : string.Empty;

                cmbColonia.SelectedValue = value.IdColonia;
                txtRenta.Text = value.Renta.ToString();
                txtMantenimiento.Text = value.Mantenimiento.ToString();
                txtDepositosRequeridos.Text = value.CantidadDepositos.ToString();
            }
        }

        private void ValidaCaptura()
        {
            try
            {
                if (cmbTipoInmueble.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbTipoInmueble.Focus();
                    throw new Exception("Seleccione tipo de inmueble");
                }
                if (cmbUsoSuelo.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbUsoSuelo.Focus();
                    throw new Exception("Seleccione tipo de uso");
                }
                if (txtCp.Text.Trim() == string.Empty)
                {
                    txtCp.Focus();
                    throw new Exception("Ingrese un codigo postal valido");
                }
                if (cmbColonia.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
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
                if (txtRenta.Text.Trim() == string.Empty)
                {
                    txtNoExt.Focus();
                    throw new Exception("Ingrese monto de renta");
                }
                if (txtMantenimiento.Text.Trim() == string.Empty)
                {
                    txtNoExt.Focus();
                    throw new Exception("Ingrese monto de mantenimiento");
                }
                if (txtDepositosRequeridos.Text.Trim() == string.Empty)
                {
                    txtNoExt.Focus();
                    throw new Exception("Ingrese numero de depositos requeridos");
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                ;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCaptura();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                UtilsEventos.Numero2Decimales(sender, e);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
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

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

    }
}
