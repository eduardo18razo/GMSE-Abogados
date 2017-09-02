using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Polizas.Business.Catalogos;
using Polizas.Business.Manager;
using Polizas.Entities.Helpers;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmAltaTelefono : Form
    {
        private readonly BusinessTipoTelefono _bTipoTelefono = new BusinessTipoTelefono();
        public FrmAltaTelefono()
        {
            InitializeComponent();

            LlenaTipoTelefono();
        }

        public HelperTelefonos Telefono
        {
            get
            {
                HelperTelefonos ht = new HelperTelefonos();
                ht.IdTipoTelefono = int.Parse(cmbTipo.SelectedValue.ToString());
                ht.TipoTelefono = cmbTipo.Text;
                ht.Numero = txtNumero.Text.Trim();
                ht.Extension = txtExtension.Text.Trim();
                Telefono = ht;
                return ht;
            }
            set
            {
                if (value != null)
                {
                    cmbTipo.SelectedValue = value.IdTipoTelefono;
                    txtNumero.Text = value.Numero;
                    txtExtension.Text = value.Extension;
                }
            }
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
            try
            {
                UtilsEventos.SoloNumeros(sender, e);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
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
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void FrmAltaTelefono_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
