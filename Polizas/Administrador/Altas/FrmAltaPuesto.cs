using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Business.Catalogos;
using Polizas.Entities.Usuarios;
using Polizas.Utils;

namespace Polizas.Administrador.Altas
{
    public partial class FrmAltaPuesto : Form
    {
        readonly BusinessPuesto _bPuesto = new BusinessPuesto();
        private bool _nuevo = true;
        private Puesto _puesto;
        public FrmAltaPuesto()
        {
            InitializeComponent();
        }

        public Puesto Puesto
        {
            set
            {
                txtDescripcion.Text = value.Descripcion;
                _nuevo = false;
            }
        }

        private void Limpiar()
        {
            try
            {
                txtDescripcion.Text = string.Empty;
                _puesto = null;
                _nuevo = true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim() == string.Empty)
                    throw new Exception("Ingrese una descripción");
                _puesto = _puesto ?? new Puesto();
                _puesto.Descripcion = txtDescripcion.Text.Trim();
                if (_nuevo)
                    _bPuesto.Guardar(_puesto);
                else
                    _bPuesto.Actualizar(_puesto);
                Limpiar();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
