using System;
using System.Windows.Forms;
using Polizas.Acceso;

namespace Polizas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmSplash.ShowSplashScreen();
            FrmSplash.SetStatus("Inizializando...");
            System.Threading.Thread.Sleep(1500);
            Application.Run(new FrmLogin());
        }
    }
}
