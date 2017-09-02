using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Polizas.Business.Manager;
using Polizas.Business.Operacion;
using Polizas.Entities.Clientes;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class FrmDetalleRegistro : Form
    {
        readonly BusinessCliente _bRegistro = new BusinessCliente();
        private Cliente _registro;
        public FrmDetalleRegistro(int idRegistro)
        {
            InitializeComponent();
            _registro = _bRegistro.ObtenerCliente(idRegistro);
        }

        

        private void FrmDetalleRegistro_Load(object sender, EventArgs e)
        {
            try
            {
                DropBoxManager dbm = new DropBoxManager();
                Dictionary<string, string> files = dbm.GetFiles(_registro.Nombre);
                foreach (KeyValuePair<string, string> file in files)
                {
                    UsrCtrlFile fileCtrl = new UsrCtrlFile(file.Value, file.Key) { Dock = DockStyle.Top };
                    fileCtrl.Width = flpDoctos.Width - 10;
                    flpDoctos.Controls.Add(fileCtrl);
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }

        }
    }
}
