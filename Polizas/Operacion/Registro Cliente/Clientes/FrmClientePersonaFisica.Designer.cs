using Polizas.UserControls;

namespace Polizas.Operacion.Clientes
{
    partial class FrmClientePersonaFisica
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
            this.btnGenerardocumento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.chkActividadEmpresarial = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepLegal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.ucDireccion1 = new UserControls.UcDireccion();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarTelefono = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btneliminarInmueble = new System.Windows.Forms.Button();
            this.btnAgregarInmueble = new System.Windows.Forms.Button();
            this.dgvInmuebles = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerardocumento
            // 
            this.btnGenerardocumento.Location = new System.Drawing.Point(542, 563);
            this.btnGenerardocumento.Name = "btnGenerardocumento";
            this.btnGenerardocumento.Size = new System.Drawing.Size(125, 23);
            this.btnGenerardocumento.TabIndex = 7;
            this.btnGenerardocumento.Text = "Guardar";
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
            this.txtRepLegal.Size = new System.Drawing.Size(263, 20);
            this.txtRepLegal.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "R.F.C.";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(470, 82);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(197, 20);
            this.txtRfc.TabIndex = 5;
            // 
            // ucDireccion1
            // 
            this.ucDireccion1.Direccion = null;
            this.ucDireccion1.Location = new System.Drawing.Point(27, 108);
            this.ucDireccion1.Name = "ucDireccion1";
            this.ucDireccion1.Size = new System.Drawing.Size(640, 140);
            this.ucDireccion1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarTelefono);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.dgvTelefonos);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(27, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefonos";
            // 
            // btnEliminarTelefono
            // 
            this.btnEliminarTelefono.Location = new System.Drawing.Point(559, 49);
            this.btnEliminarTelefono.Name = "btnEliminarTelefono";
            this.btnEliminarTelefono.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTelefono.TabIndex = 2;
            this.btnEliminarTelefono.Text = "Eliminar";
            this.btnEliminarTelefono.UseVisualStyleBackColor = true;
            this.btnEliminarTelefono.Click += new System.EventHandler(this.btnEliminarTelefono_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(559, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTelefonos
            // 
            this.dgvTelefonos.AllowUserToAddRows = false;
            this.dgvTelefonos.AllowUserToDeleteRows = false;
            this.dgvTelefonos.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Location = new System.Drawing.Point(23, 19);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.ReadOnly = true;
            this.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefonos.Size = new System.Drawing.Size(530, 120);
            this.dgvTelefonos.TabIndex = 0;
            this.dgvTelefonos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefonos_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btneliminarInmueble);
            this.groupBox2.Controls.Add(this.btnAgregarInmueble);
            this.groupBox2.Controls.Add(this.dgvInmuebles);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(27, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 149);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inmuebles";
            // 
            // btneliminarInmueble
            // 
            this.btneliminarInmueble.Location = new System.Drawing.Point(559, 48);
            this.btneliminarInmueble.Name = "btneliminarInmueble";
            this.btneliminarInmueble.Size = new System.Drawing.Size(75, 23);
            this.btneliminarInmueble.TabIndex = 3;
            this.btneliminarInmueble.Text = "Eliminar";
            this.btneliminarInmueble.UseVisualStyleBackColor = true;
            this.btneliminarInmueble.Click += new System.EventHandler(this.btneliminarInmueble_Click);
            // 
            // btnAgregarInmueble
            // 
            this.btnAgregarInmueble.Location = new System.Drawing.Point(559, 19);
            this.btnAgregarInmueble.Name = "btnAgregarInmueble";
            this.btnAgregarInmueble.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarInmueble.TabIndex = 2;
            this.btnAgregarInmueble.Text = "Agregar...";
            this.btnAgregarInmueble.UseVisualStyleBackColor = true;
            this.btnAgregarInmueble.Click += new System.EventHandler(this.btnAgregarInmueble_Click);
            // 
            // dgvInmuebles
            // 
            this.dgvInmuebles.AllowUserToAddRows = false;
            this.dgvInmuebles.AllowUserToDeleteRows = false;
            this.dgvInmuebles.BackgroundColor = System.Drawing.Color.White;
            this.dgvInmuebles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInmuebles.Location = new System.Drawing.Point(23, 19);
            this.dgvInmuebles.Name = "dgvInmuebles";
            this.dgvInmuebles.ReadOnly = true;
            this.dgvInmuebles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInmuebles.Size = new System.Drawing.Size(530, 120);
            this.dgvInmuebles.TabIndex = 0;
            this.dgvInmuebles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInmuebles_CellDoubleClick);
            // 
            // FrmClientePersonaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucDireccion1);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRepLegal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkActividadEmpresarial);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerardocumento);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "FrmClientePersonaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Persona Fisica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInmuebles)).EndInit();
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
        private System.Windows.Forms.CheckBox chkActividadEmpresarial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepLegal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRfc;
        private UcDireccion ucDireccion1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.Button btnEliminarTelefono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btneliminarInmueble;
        private System.Windows.Forms.Button btnAgregarInmueble;
        private System.Windows.Forms.DataGridView dgvInmuebles;
    }
}