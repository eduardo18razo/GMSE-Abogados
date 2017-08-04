using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dropbox.Api.Team;
using Polizas.Business;
using Polizas.Utils;

namespace Polizas.Operacion
{
    public partial class UsrCtrlFile : UserControl
    {
        readonly DropBoxManager _dbx = new DropBoxManager();
        private string _filePath;
        private string _fileName;
        public UsrCtrlFile(string fileName, string fullFilePath)
        {
            InitializeComponent();
            lnkFileName.Text = fileName;
            _filePath = fullFilePath;
            _fileName = fileName;
            
        }

        private void UsrCtrlFile_Load(object sender, EventArgs e)
        {

        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (await _dbx.DownloadFile(_filePath, _fileName))
                {
                    string archivoImprimir = BusinessVariables.Directorio.DirectorioAplciacion +
                                             BusinessVariables.Directorio.CarpetaTemporales + _fileName;
                    bool existeArchivo = true;
                    while (existeArchivo)
                    {
                        existeArchivo = !File.Exists(archivoImprimir);
                    }
                    ProcessStartInfo info = new ProcessStartInfo(archivoImprimir);
                    info.Verb = "Print";
                    info.CreateNoWindow = true;
                    info.WindowStyle = ProcessWindowStyle.Hidden;
                    Process.Start(info);
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private async void lnkFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (await _dbx.DownloadFile(_filePath, _fileName))
                {
                    Process.Start(BusinessVariables.Directorio.DirectorioAplciacion +
                                  BusinessVariables.Directorio.CarpetaTemporales + _fileName);
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
