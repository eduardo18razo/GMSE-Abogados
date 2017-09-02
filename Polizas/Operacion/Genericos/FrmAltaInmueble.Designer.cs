namespace Polizas.Operacion.Genericos
{
    partial class FrmAltaInmueble
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
            this.gbInmuebles = new System.Windows.Forms.GroupBox();
            this.txtDepositosRequeridos = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNoInt = new System.Windows.Forms.TextBox();
            this.txtNoExt = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.cmbUsoSuelo = new System.Windows.Forms.ComboBox();
            this.cmbTipoInmueble = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbInmuebles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInmuebles
            // 
            this.gbInmuebles.Controls.Add(this.txtDepositosRequeridos);
            this.gbInmuebles.Controls.Add(this.txtMantenimiento);
            this.gbInmuebles.Controls.Add(this.txtRenta);
            this.gbInmuebles.Controls.Add(this.label8);
            this.gbInmuebles.Controls.Add(this.label2);
            this.gbInmuebles.Controls.Add(this.label1);
            this.gbInmuebles.Controls.Add(this.btnAceptar);
            this.gbInmuebles.Controls.Add(this.txtNoInt);
            this.gbInmuebles.Controls.Add(this.txtNoExt);
            this.gbInmuebles.Controls.Add(this.txtCalle);
            this.gbInmuebles.Controls.Add(this.label5);
            this.gbInmuebles.Controls.Add(this.label3);
            this.gbInmuebles.Controls.Add(this.label4);
            this.gbInmuebles.Controls.Add(this.cmbColonia);
            this.gbInmuebles.Controls.Add(this.txtCp);
            this.gbInmuebles.Controls.Add(this.cmbUsoSuelo);
            this.gbInmuebles.Controls.Add(this.cmbTipoInmueble);
            this.gbInmuebles.Controls.Add(this.label12);
            this.gbInmuebles.Controls.Add(this.label11);
            this.gbInmuebles.Controls.Add(this.label7);
            this.gbInmuebles.Controls.Add(this.label6);
            this.gbInmuebles.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbInmuebles.Location = new System.Drawing.Point(12, 12);
            this.gbInmuebles.Name = "gbInmuebles";
            this.gbInmuebles.Size = new System.Drawing.Size(535, 219);
            this.gbInmuebles.TabIndex = 15;
            this.gbInmuebles.TabStop = false;
            this.gbInmuebles.Text = "Inmuebles";
            // 
            // txtDepositosRequeridos
            // 
            this.txtDepositosRequeridos.Location = new System.Drawing.Point(451, 144);
            this.txtDepositosRequeridos.Name = "txtDepositosRequeridos";
            this.txtDepositosRequeridos.Size = new System.Drawing.Size(68, 20);
            this.txtDepositosRequeridos.TabIndex = 28;
            this.txtDepositosRequeridos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenta_KeyPress);
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(244, 144);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(69, 20);
            this.txtMantenimiento.TabIndex = 27;
            this.txtMantenimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenta_KeyPress);
            // 
            // txtRenta
            // 
            this.txtRenta.Location = new System.Drawing.Point(62, 144);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(69, 20);
            this.txtRenta.TabIndex = 26;
            this.txtRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRenta_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Depositos requeridos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Renta";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(444, 175);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNoInt
            // 
            this.txtNoInt.Location = new System.Drawing.Point(450, 105);
            this.txtNoInt.Name = "txtNoInt";
            this.txtNoInt.Size = new System.Drawing.Size(69, 20);
            this.txtNoInt.TabIndex = 18;
            // 
            // txtNoExt
            // 
            this.txtNoExt.Location = new System.Drawing.Point(313, 105);
            this.txtNoExt.Name = "txtNoExt";
            this.txtNoExt.Size = new System.Drawing.Size(69, 20);
            this.txtNoExt.TabIndex = 17;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(56, 105);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(186, 20);
            this.txtCalle.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "No Interior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "No Exterior";
            // 
            // cmbColonia
            // 
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(219, 65);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(300, 21);
            this.cmbColonia.TabIndex = 15;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(99, 65);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(69, 20);
            this.txtCp.TabIndex = 14;
            this.txtCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCp_KeyDown);
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            this.txtCp.Leave += new System.EventHandler(this.txtCp_Leave);
            // 
            // cmbUsoSuelo
            // 
            this.cmbUsoSuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsoSuelo.FormattingEnabled = true;
            this.cmbUsoSuelo.Location = new System.Drawing.Point(353, 25);
            this.cmbUsoSuelo.Name = "cmbUsoSuelo";
            this.cmbUsoSuelo.Size = new System.Drawing.Size(166, 21);
            this.cmbUsoSuelo.TabIndex = 8;
            // 
            // cmbTipoInmueble
            // 
            this.cmbTipoInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoInmueble.FormattingEnabled = true;
            this.cmbTipoInmueble.Location = new System.Drawing.Point(99, 25);
            this.cmbTipoInmueble.Name = "cmbTipoInmueble";
            this.cmbTipoInmueble.Size = new System.Drawing.Size(143, 21);
            this.cmbTipoInmueble.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Colonia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Codigo Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tipo de Uso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tipo Inmueble";
            // 
            // FrmAltaInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 244);
            this.Controls.Add(this.gbInmuebles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaInmueble";
            this.Text = "Alta Inmueble";
            this.Load += new System.EventHandler(this.FrmAltaInmueble_Load);
            this.gbInmuebles.ResumeLayout(false);
            this.gbInmuebles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInmuebles;
        private System.Windows.Forms.TextBox txtDepositosRequeridos;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNoInt;
        private System.Windows.Forms.TextBox txtNoExt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.ComboBox cmbUsoSuelo;
        private System.Windows.Forms.ComboBox cmbTipoInmueble;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}