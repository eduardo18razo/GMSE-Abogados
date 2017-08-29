namespace Polizas.Acceso
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaFisicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaMoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.atencionTelefonicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrendatariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atencionTelefonicaToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.polizasToolStripMenuItem,
            this.arrendatariosToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.toolConfiguracion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaFisicaToolStripMenuItem,
            this.personaMoralToolStripMenuItem,
            this.consultaRegistrosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.registrosToolStripMenuItem.Text = "Clientes";
            // 
            // personaFisicaToolStripMenuItem
            // 
            this.personaFisicaToolStripMenuItem.Name = "personaFisicaToolStripMenuItem";
            this.personaFisicaToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.personaFisicaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.personaFisicaToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.personaFisicaToolStripMenuItem.Text = "Persona Fisica";
            this.personaFisicaToolStripMenuItem.Click += new System.EventHandler(this.personaFisicaToolStripMenuItem_Click);
            // 
            // personaMoralToolStripMenuItem
            // 
            this.personaMoralToolStripMenuItem.Name = "personaMoralToolStripMenuItem";
            this.personaMoralToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.personaMoralToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.personaMoralToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.personaMoralToolStripMenuItem.Text = "Persona Moral";
            this.personaMoralToolStripMenuItem.Click += new System.EventHandler(this.personaMoralToolStripMenuItem_Click);
            // 
            // consultaRegistrosToolStripMenuItem
            // 
            this.consultaRegistrosToolStripMenuItem.Name = "consultaRegistrosToolStripMenuItem";
            this.consultaRegistrosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.consultaRegistrosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.consultaRegistrosToolStripMenuItem.Text = "Consulta Registros";
            this.consultaRegistrosToolStripMenuItem.Click += new System.EventHandler(this.consultaRegistrosToolStripMenuItem_Click);
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esencialToolStripMenuItem,
            this.totalToolStripMenuItem});
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // esencialToolStripMenuItem
            // 
            this.esencialToolStripMenuItem.Name = "esencialToolStripMenuItem";
            this.esencialToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.esencialToolStripMenuItem.Text = "Esencial";
            this.esencialToolStripMenuItem.Click += new System.EventHandler(this.esencialToolStripMenuItem_Click);
            // 
            // totalToolStripMenuItem
            // 
            this.totalToolStripMenuItem.Name = "totalToolStripMenuItem";
            this.totalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.totalToolStripMenuItem.Text = "Total";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendatToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 27);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agendatToolStripMenuItem
            // 
            this.agendatToolStripMenuItem.Name = "agendatToolStripMenuItem";
            this.agendatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.agendatToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agendatToolStripMenuItem.Text = "Agenda";
            this.agendatToolStripMenuItem.Click += new System.EventHandler(this.agendatToolStripMenuItem_Click);
            // 
            // toolConfiguracion
            // 
            this.toolConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.puestosToolStripMenuItem});
            this.toolConfiguracion.Name = "toolConfiguracion";
            this.toolConfiguracion.Size = new System.Drawing.Size(95, 27);
            this.toolConfiguracion.Text = "Configuración";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Polizas.Properties.Resources.LOGO_WEB_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 115);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 31);
            this.panel2.TabIndex = 5;
            // 
            // atencionTelefonicaToolStripMenuItem
            // 
            this.atencionTelefonicaToolStripMenuItem.Name = "atencionTelefonicaToolStripMenuItem";
            this.atencionTelefonicaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.atencionTelefonicaToolStripMenuItem.Size = new System.Drawing.Size(124, 27);
            this.atencionTelefonicaToolStripMenuItem.Text = "Atencion Telefonica";
            this.atencionTelefonicaToolStripMenuItem.Click += new System.EventHandler(this.atencionTelefonicaToolStripMenuItem_Click);
            // 
            // arrendatariosToolStripMenuItem
            // 
            this.arrendatariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.arrendatariosToolStripMenuItem.Name = "arrendatariosToolStripMenuItem";
            this.arrendatariosToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.arrendatariosToolStripMenuItem.Text = "Arrendatarios";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registroToolStripMenuItem.Text = "Alta";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaFisicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaMoralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem consultaRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atencionTelefonicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrendatariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
    }
}