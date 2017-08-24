using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities.Clientes;
using Polizas.Entities.Helpers;

namespace Polizas.Operacion
{
    public partial class FrmRegistroPersonaMoral : Form
    {
        public FrmRegistroPersonaMoral()
        {
            InitializeComponent();
        }

        private bool ValidaCaptura()
        {
            bool result = true;
            if (txtNombre.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Capture nombre", "Polizas Juridicas");
                txtNombre.Focus();
                result = false;
            }
            if (dpFecha.Text.Trim() == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                if (MessageBox.Show("La fecha es la misma que hoy \n¿Esta seguro?", "Polizas Juridicas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    dpFecha.Focus();
                    result = false;
                }
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaCaptura())
                {
                    BusinessCliente documentManager = new BusinessCliente();
                    Cliente cte = new Cliente
                    {
                        Expediente = txtExpediente.Text,
                        Nombre = txtNombre.Text,
                        PersonaFisica = false,
                        Correo = txtCorreo.Text,
                        IdUsuarioAlta = Properties.Settings.userData.Id,
                        ClienteDireccion = new List<ClienteDireccion>
                        {
                            new ClienteDireccion
                            {
                                Calle = ucDireccion1.Direccion.Calle,
                                IdColonia = ucDireccion1.Direccion.IdColonia,
                                NoExt = ucDireccion1.Direccion.NoExt,
                                NoInt = ucDireccion1.Direccion.NoInt
                            }
                        },
                        ClienteTelefono = new List<ClienteTelefono>()
                    };
                    foreach (HelperTelefonos telefono in ucTelefonos.Telefonos)
                    {
                        cte.ClienteTelefono.Add(new ClienteTelefono
                        {
                            IdTipoTelefono = telefono.IdTipoTelefono,
                            Telefono = telefono.Numero,
                            Extensiones = telefono.Extension,
                        });
                    }
                    documentManager.GuardarCliente(cte);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
