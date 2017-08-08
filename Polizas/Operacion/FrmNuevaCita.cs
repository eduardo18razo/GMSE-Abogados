using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmNuevaCita : Form
    {
        readonly BusinessUsuario _bUsuarios = new BusinessUsuario();
        readonly BusinessRegistro _bRegistros = new BusinessRegistro();
        readonly BusinessCita _bCita = new BusinessCita();
        public FrmNuevaCita()
        {
            InitializeComponent();
        }

        public Cita Cita { get; set; }

        private void LLenaCombos()
        {
            try
            {
                cmbUsuario.DataSource = _bUsuarios.ObtenerUsuarios(true);
                cmbUsuario.DisplayMember = "Nombre";
                cmbUsuario.ValueMember = "Id";
                cmbCliente.DataSource = _bRegistros.ObtenerRegistros(true);
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "Id";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void FrmNuevaCita_Load(object sender, EventArgs e)
        {
            try
            {
                LLenaCombos();
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
                if (cmbUsuario.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbUsuario.Focus();
                    throw new Exception("Seleccione un usuario a asignar");
                }
                if (cmbCliente.SelectedIndex == BusinessVariables.ComboBoxCatalogo.IndexSeleccione)
                {
                    cmbCliente.Focus();
                    throw new Exception("Seleccione un cliente para agendar");
                }
                if (txtDescripcion.Text.Trim() == string.Empty)
                {
                    txtDescripcion.Focus();
                    throw new Exception("Ingrese una descripción para la cita");
                }
                Cita.IdUsuario = int.Parse(cmbUsuario.SelectedValue.ToString());
                Cita.IdRegistro = int.Parse(cmbCliente.SelectedValue.ToString());
                Cita.Text = txtDescripcion.Text.Trim();
                _bCita.CrearCita(Cita);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
