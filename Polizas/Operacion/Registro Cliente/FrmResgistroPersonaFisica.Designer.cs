﻿namespace Polizas.Operacion
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
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.FechaGeneracion = new System.Windows.Forms.Label();
            this.ucDireccion1 = new Polizas.Administrador.UcDireccion();
            this.ucTelefonos = new Polizas.Administrador.UcTelefonos();
            this.SuspendLayout();
            // 
            // btnGenerardocumento
            // 
            this.btnGenerardocumento.Location = new System.Drawing.Point(611, 498);
            this.btnGenerardocumento.Name = "btnGenerardocumento";
            this.btnGenerardocumento.Size = new System.Drawing.Size(125, 23);
            this.btnGenerardocumento.TabIndex = 6;
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
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expediente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(237, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // dpFecha
            // 
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(93, 82);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(323, 20);
            this.dpFecha.TabIndex = 3;
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
            this.txtCorreo.TabIndex = 2;
            // 
            // FechaGeneracion
            // 
            this.FechaGeneracion.AutoSize = true;
            this.FechaGeneracion.Location = new System.Drawing.Point(24, 88);
            this.FechaGeneracion.Name = "FechaGeneracion";
            this.FechaGeneracion.Size = new System.Drawing.Size(35, 13);
            this.FechaGeneracion.TabIndex = 9;
            this.FechaGeneracion.Text = "label4";
            // 
            // ucDireccion1
            // 
            this.ucDireccion1.Location = new System.Drawing.Point(27, 118);
            this.ucDireccion1.Name = "ucDireccion1";
            this.ucDireccion1.Size = new System.Drawing.Size(640, 140);
            this.ucDireccion1.TabIndex = 4;
            // 
            // ucTelefonos
            // 
            this.ucTelefonos.Location = new System.Drawing.Point(27, 264);
            this.ucTelefonos.Name = "ucTelefonos";
            this.ucTelefonos.Size = new System.Drawing.Size(640, 225);
            this.ucTelefonos.TabIndex = 5;
            this.ucTelefonos.Telefonos = null;
            // 
            // FrmRegistroPersonaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 545);
            this.Controls.Add(this.ucTelefonos);
            this.Controls.Add(this.ucDireccion1);
            this.Controls.Add(this.FechaGeneracion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerardocumento);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MinimumSize = new System.Drawing.Size(764, 584);
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
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label FechaGeneracion;
        private Administrador.UcDireccion ucDireccion1;
        private Administrador.UcTelefonos ucTelefonos;
    }
}
