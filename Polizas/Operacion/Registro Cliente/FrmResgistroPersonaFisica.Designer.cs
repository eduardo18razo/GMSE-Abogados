using Polizas.Administrador;

namespace Polizas.Operacion
{
    partial class FrmRegistroPersonaFisica
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerardocumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.ucDireccion1 = new UcDireccion();
            this.ucTelefonos = new UcTelefonos();
            this.chkActividadEmpresarial = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepLegal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerardocumento
            // 
            this.btnGenerardocumento.Location = new System.Drawing.Point(542, 522);
            this.btnGenerardocumento.Name = "btnGenerardocumento";
            this.btnGenerardocumento.Size = new System.Drawing.Size(125, 23);
            this.btnGenerardocumento.TabIndex = 7;
            this.btnGenerardocumento.Text = "Generar Documentos";
            this.btnGenerardocumento.UseVisualStyleBackColor = true;
            this.btnGenerardocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contrato";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(93, 30);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtExpediente.TabIndex = 0;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(430, 56);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // ucDireccion1
            // 
            this.ucDireccion1.Location = new System.Drawing.Point(27, 134);
            this.ucDireccion1.Name = "ucDireccion1";
            this.ucDireccion1.Size = new System.Drawing.Size(640, 140);
            this.ucDireccion1.TabIndex = 6;
            // 
            // ucTelefonos
            // 
            this.ucTelefonos.Location = new System.Drawing.Point(27, 280);
            this.ucTelefonos.Name = "ucTelefonos";
            this.ucTelefonos.Size = new System.Drawing.Size(640, 225);
            this.ucTelefonos.TabIndex = 7;
            this.ucTelefonos.Telefonos = null;
            // 
            // chkActividadEmpresarial
            // 
            this.chkActividadEmpresarial.AutoSize = true;
            this.chkActividadEmpresarial.Checked = true;
            this.chkActividadEmpresarial.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkActividadEmpresarial.Location = new System.Drawing.Point(213, 32);
            this.chkActividadEmpresarial.Name = "chkActividadEmpresarial";
            this.chkActividadEmpresarial.Size = new System.Drawing.Size(127, 17);
            this.chkActividadEmpresarial.TabIndex = 1;
            this.chkActividadEmpresarial.Text = "Actividad Empresarial";
            this.chkActividadEmpresarial.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Representante Legal";
            // 
            // txtRepLegal
            // 
            this.txtRepLegal.Location = new System.Drawing.Point(136, 82);
            this.txtRepLegal.Name = "txtRepLegal";
            this.txtRepLegal.Size = new System.Drawing.Size(531, 20);
            this.txtRepLegal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "R.F.C.";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(93, 108);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(237, 20);
            this.txtRfc.TabIndex = 5;
            // 
            // FrmRegistroPersonaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 566);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepLegal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkActividadEmpresarial);
            this.Controls.Add(this.ucTelefonos);
            this.Controls.Add(this.ucDireccion1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerardocumento);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "FrmRegistroPersonaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Persona Fisica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerardocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtCorreo;
        private Administrador.UcDireccion ucDireccion1;
        private Administrador.UcTelefonos ucTelefonos;
        private System.Windows.Forms.CheckBox chkActividadEmpresarial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepLegal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRfc;
    }
}

