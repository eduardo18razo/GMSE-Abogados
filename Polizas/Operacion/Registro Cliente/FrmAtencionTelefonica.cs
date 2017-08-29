using System;
using System.Threading;
using System.Windows.Forms;
using Polizas.Business.Manager;
using Polizas.Business.Operacion;
using Polizas.Business.Sistema;
using Polizas.Entities;
using Polizas.Entities.Clientes;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmAtencionTelefonica : Form
    {
        private readonly BusinessMedioContacto _bMedioContacto = new BusinessMedioContacto();
        private readonly BusinessTipoPoliza _bTipoPoliza = new BusinessTipoPoliza();
        private readonly BusinessTipoUso _bTipoUso = new BusinessTipoUso();
        private readonly BusinessCliente _bCliente = new BusinessCliente();
        private readonly BusinessAtencionTelefonica _bAtencionTelefonica = new BusinessAtencionTelefonica();
        public FrmAtencionTelefonica()
        {
            InitializeComponent();
        }

        private void LlenaDatosCombo()
        {
            try
            {
                cmbMedio.DataSource = _bMedioContacto.ObtenerMediosPublicidad(true);
                cmbMedio.DisplayMember = "Descripcion";
                cmbMedio.ValueMember = "Id";

                cmbTipoPoliza.DataSource = _bTipoPoliza.ObtenerMediosPublicidad(true);
                cmbTipoPoliza.DisplayMember = "Descripcion";
                cmbTipoPoliza.ValueMember = "Id";

                cmbUsoSuelo.DataSource = _bTipoUso.ObtenerMediosPublicidad(true);
                cmbUsoSuelo.DisplayMember = "Descripcion";
                cmbUsoSuelo.ValueMember = "Id";

                cmbReferencia.DataSource = _bCliente.ObtenerClientes(true);
                cmbReferencia.DisplayMember = "Nombre";
                cmbReferencia.ValueMember = "Id";
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
                if (txtNombre.Text == string.Empty)
                {
                    txtNombre.Focus();
                    throw new Exception("Nombre es campo obligatorio");
                }
                if (cmbMedio.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbMedio.Focus();
                    throw new Exception("Especifique un medio de Contacto");
                }
                if (cmbTipoPoliza.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbTipoPoliza.Focus();
                    throw new Exception("Especifique un Tipo de Poliza");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void LimpiarCampos()
        {
            try
            {
                txtNombre.Text = string.Empty;
                cmbMedio.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                cmbReferencia.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                cmbUsoSuelo.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                cmbTipoPoliza.SelectedIndex = BusinessVariables.ComboBoxCatalogo.IndexSeleccione;
                txtRenta.Text = string.Empty;
                txtObservaciones.Text = string.Empty;
                txtNotas.Text = string.Empty;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void FrmAtencionTelefonica_Load(object sender, EventArgs e)
        {
            try
            {
                LlenaDatosCombo();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCaptura();
                AtencionTelefonica atencion = new AtencionTelefonica
                {
                    Cliente = new Cliente { Nombre = txtNombre.Text, IdUsuarioReferencia = (long?)(cmbReferencia.SelectedIndex <= BusinessVariables.ComboBoxCatalogo.IndexSeleccione ? null : cmbReferencia.SelectedValue) },
                    IdMedioPublicidad = int.Parse(cmbMedio.SelectedValue.ToString()),
                    IdTipoUso = int.Parse(cmbUsoSuelo.SelectedValue.ToString()),
                    IdTipoPoliza = int.Parse(cmbTipoPoliza.SelectedValue.ToString()),
                    RentaCosto = decimal.Parse(txtRenta.Text),
                    Observaciones = txtObservaciones.Text,
                    Nota = txtNotas.Text
                };
                _bAtencionTelefonica.Guardar(atencion);
                LimpiarCampos();
                Mensajes.Exito("Cliente Registrado");
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                UtilsEventos.SoloNumeros(sender, e);
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
    }
}
