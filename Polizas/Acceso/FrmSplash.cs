using System;
using System.Threading;
using System.Windows.Forms;

namespace Polizas.Acceso
{
    public partial class FrmSplash : Form
    {
         private double _mDblOpacityIncrement = .05;
        private static Thread _msOThread = null;
        private static FrmSplash _frmSplash;
        private string _statusDescripcion;
        private static bool _closed;
        
        public FrmSplash()
        {
            InitializeComponent();
            UpdateTimer.Start();
        }

        static public void CloseForm()
        {
            _closed = true;
            _msOThread = null;
        }

        static private void ShowForm()
        {
            _frmSplash = new FrmSplash();
            Application.Run(_frmSplash);
        }
        private void UpdateTimer_Tick(object sender, System.EventArgs e)
        {
            if (_closed)
                Close();
            lblStatus.Text = _statusDescripcion;
            if (!(_mDblOpacityIncrement > 0)) return;
            if (Opacity < 1)
                Opacity += _mDblOpacityIncrement;

        }
        static public void ShowSplashScreen()
        {
            if (_frmSplash != null) return;
            _msOThread = new Thread(ShowForm);
            _msOThread.IsBackground = true;
            _msOThread.SetApartmentState(ApartmentState.STA);
            _msOThread.Start();
        }

        public static void SetStatus(string status)
        {
            SetStatus(status, true);
        }

        static public void SetStatus(string newStatus, bool setReference)
        {
            if (_frmSplash == null)
                return;

            _frmSplash._statusDescripcion = newStatus;
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
