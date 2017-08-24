using System;
using System.Windows.Forms;
using Polizas.Administrador;
using Polizas.Administrador.Altas;
using Polizas.Administrador.Consultas;
using Polizas.Entities;
using Polizas.Entities.Usuarios;
using Polizas.Operacion;
using Polizas.Operacion.Polizas;
using Polizas.Utils;

namespace Polizas.Acceso
{
    public partial class FrmMain : Form
    {
        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public FrmMain(Usuario userData)
        {
            InitializeComponent();
            Properties.Settings.userData = userData;
            //toolConfiguracion.Visible = !(userData.IdRol == 2);
            Text = string.Format("Polizas Juridicas - {0}", userData.Nombre);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.userData = null;

        }


        private void personaFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPersonaFisica registroPersonafisica = new FrmRegistroPersonaFisica();
            registroPersonafisica.MdiParent = this;
            registroPersonafisica.Show();
        }

        private void personaMoralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroPersonaMoral registroPersonafisica = new FrmRegistroPersonaMoral();
            registroPersonafisica.MdiParent = this;
            registroPersonafisica.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void consultaRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaRegistros frmConsultaRegistros = new FrmConsultaRegistros();
            frmConsultaRegistros.MdiParent = this;
            frmConsultaRegistros.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRol frmRoles = new FrmRol();
                frmRoles.MdiParent = this;
                frmRoles.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void agendatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDayView frmAgenda = new FrmDayView();
                frmAgenda.MdiParent = this;
                frmAgenda.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRolPantalla frmRolPantalla = new FrmRolPantalla();
                frmRolPantalla.MdiParent = this;
                frmRolPantalla.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPuestos frmPuesto = new FrmPuestos();
                frmPuesto.MdiParent = this;
                frmPuesto.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void esencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPolizaEscencial frmPoliza = new FrmPolizaEscencial();
                frmPoliza.MdiParent = this;
                frmPoliza.Show();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        
    }
}
