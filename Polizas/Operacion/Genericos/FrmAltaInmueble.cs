using System;
using System.Windows.Forms;
using Polizas.Business.Catalogos;
using Polizas.Business.Manager;
using Polizas.Business.Sistema;
using Polizas.Entities.Helpers;
using Polizas.Entities.Ubicacion;
using Polizas.Utils;

namespace Polizas.Operacion.Genericos
{
    public partial class FrmAltaInmueble : Form
    {
        private readonly BusinessTipoInmueble _bTipoInmueble = new BusinessTipoInmueble();
        private readonly BusinessTipoUso _bTipoUso = new BusinessTipoUso();
        private readonly  BusinessColonia _bColonia = new BusinessColonia();
        public FrmAltaInmueble()
        {
            InitializeComponent();
            LlenaCombos();
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
                HelperInmueble inm = new HelperInmueble
                {
                    IdTipoInmueble = int.Parse(cmbTipoInmueble.SelectedValue.ToString()),
                    TipoInmueble = cmbTipoInmueble.Text,
                    IdTipoUso = int.Parse(cmbUsoSuelo.SelectedValue.ToString()),
                    UsoSuelo = cmbUsoSuelo.Text,
                    Calle = txtCalle.Text.Trim(),
                    NoExt = txtNoExt.Text.Trim(),
                    NoInt = txtNoInt.Text.Trim(),
                    IdColonia = int.Parse(cmbColonia.SelectedValue.ToString()),
                    Renta = decimal.Parse(txtRenta.Text),
                    Mantenimiento = decimal.Parse(txtMantenimiento.Text),
                    NumeroDepositos = decimal.Parse(txtDepositosRequeridos.Text),
                };
                Colonia colonia = _bColonia.ObtenerColonia(int.Parse(cmbColonia.SelectedValue.ToString()));
                if (colonia != null)
                {
                    inm.Colonia = colonia.Descripcion;
                    inm.Municipio = colonia.Municipio.Descripcion;
                    inm.Estado = colonia.Municipio.Estado.Descripcion;
                }
                Inmueble = inm;
                return inm;
            }
            set
            {
                if (value != null)
                {
                    cmbTipoInmueble.SelectedValue = value.IdTipoInmueble;
                    cmbUsoSuelo.SelectedValue = value.IdTipoUso;
                    txtCalle.Text = value.Calle;
                    txtNoExt.Text = value.NoExt;
                    txtNoInt.Text = value.NoInt;
                    Colonia col = _bColonia.ObtenerColonia(value.IdColonia);
                    txtCp.Text = col != null ? col.CP.ToString() : string.Empty;
                    txtCp_Leave(txtCp, null);
                    cmbColonia.SelectedValue = value.IdColonia;
                    txtRenta.Text = value.Renta.ToString();
                    txtMantenimiento.Text = value.Mantenimiento.ToString();
                    txtDepositosRequeridos.Text = value.NumeroDepositos.ToString();
                }
            }
        }

        private void LlenaCombos()
        {
            try
            {
                cmbTipoInmueble.DataSource = _bTipoInmueble.ObtenerTiposInmueble(true);
                cmbTipoInmueble.DisplayMember = "Descripcion";
                cmbTipoInmueble.ValueMember = "Id";

                cmbUsoSuelo.DataSource = _bTipoUso.ObtenerMediosPublicidad(true);
                cmbUsoSuelo.DisplayMember = "Descripcion";
                cmbUsoSuelo.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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

        private void FrmAltaInmueble_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCaptura();
                
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtCp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCp.Text.Trim() != string.Empty)
                    LlenaColonias();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

    }
}
