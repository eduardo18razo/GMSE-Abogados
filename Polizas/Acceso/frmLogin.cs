using System;
using System.Windows.Forms;
using Polizas.Business;
using Polizas.Entities;
using Polizas.Entities.Usuarios;
using Polizas.Utils;

namespace Polizas.Acceso
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            SuspendLayout();
            Layout += FrmLogin_Layout;
            ResumeLayout(false);
            InitializeComponent();
        }
        private void LimpiaControles()
        {
            txtUsuario.Clear();
            txtPsw.Clear();
        }

        private bool ValidaControles()
        {
            bool result = txtUsuario.Text.Trim() == string.Empty || txtPsw.Text.Trim() == string.Empty;
            if (result)
                Mensajes.Exclamacion("Debe ingresar nombre de usuario y contraseña", Text);
            return !result;
        }
        void FrmLogin_Layout(object sender, LayoutEventArgs e)
        {
            Activate();
            FrmSplash.CloseForm();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaControles()) return;
                BusinessSecurity bSecurity = new BusinessSecurity();
                Usuario userData = bSecurity.AutenticarUsuario(txtUsuario.Text.Trim(), txtPsw.Text.Trim());
                LimpiaControles();
                FrmMain main = new FrmMain(userData);
                Hide();
                main.ShowDialog();
                main.Dispose();
                Show();
                txtUsuario.Focus();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPsw.Focus();
            }
        }

        private void txtPsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(btnIngresar, null);
            }

        }
    }
}
