namespace Polizas.Administrador
{
    partial class FrmAltaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPsw = new System.Windows.Forms.TextBox();
            this.chkLbxRoles = new System.Windows.Forms.CheckedListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ucTelefonos = new Polizas.Administrador.UcTelefonos();
            this.ucDireccion = new Polizas.Administrador.UcDireccion();
            this.btnAddPuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Roles";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(387, 560);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Puesto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(116, 42);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(224, 21);
            this.cmbPuesto.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(116, 69);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(254, 20);
            this.txtCorreo.TabIndex = 12;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(116, 95);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(254, 20);
            this.txtNombreUsuario.TabIndex = 13;
            // 
            // txtPsw
            // 
            this.txtPsw.Location = new System.Drawing.Point(116, 121);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.Size = new System.Drawing.Size(254, 20);
            this.txtPsw.TabIndex = 14;
            // 
            // chkLbxRoles
            // 
            this.chkLbxRoles.FormattingEnabled = true;
            this.chkLbxRoles.Location = new System.Drawing.Point(399, 35);
            this.chkLbxRoles.Name = "chkLbxRoles";
            this.chkLbxRoles.Size = new System.Drawing.Size(150, 109);
            this.chkLbxRoles.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(474, 560);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ucTelefonos
            // 
            this.ucTelefonos.Location = new System.Drawing.Point(15, 313);
            this.ucTelefonos.Name = "ucTelefonos";
            this.ucTelefonos.Size = new System.Drawing.Size(534, 225);
            this.ucTelefonos.TabIndex = 21;
            this.ucTelefonos.Telefonos = null;
            // 
            // ucDireccion
            // 
            this.ucDireccion.Location = new System.Drawing.Point(15, 167);
            this.ucDireccion.Name = "ucDireccion";
            this.ucDireccion.Size = new System.Drawing.Size(534, 140);
            this.ucDireccion.TabIndex = 20;
            // 
            // btnAddPuesto
            // 
            
            this.btnAddPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPuesto.Location = new System.Drawing.Point(346, 39);
            this.btnAddPuesto.Name = "btnAddPuesto";
            this.btnAddPuesto.Size = new System.Drawing.Size(24, 24);
            this.btnAddPuesto.TabIndex = 22;
            this.btnAddPuesto.UseVisualStyleBackColor = true;
            this.btnAddPuesto.Click += new System.EventHandler(this.btnAddPuesto_Click);
            // 
            // FrmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(577, 597);
            this.Controls.Add(this.btnAddPuesto);
            this.Controls.Add(this.ucTelefonos);
            this.Controls.Add(this.ucDireccion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkLbxRoles);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MaximumSize = new System.Drawing.Size(593, 636);
            this.MinimumSize = new System.Drawing.Size(593, 636);
            this.Name = "FrmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de usuario";
            this.Load += new System.EventHandler(this.FrmAltaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPsw;
        private System.Windows.Forms.CheckedListBox chkLbxRoles;
        private System.Windows.Forms.Button btnCancelar;
        private UcDireccion ucDireccion;
        private UcTelefonos ucTelefonos;
        private System.Windows.Forms.Button btnAddPuesto;
    }
}