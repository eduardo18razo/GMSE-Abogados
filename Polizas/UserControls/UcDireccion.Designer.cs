namespace Polizas.UserControls
{
    partial class UcDireccion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColonia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNoExt = new System.Windows.Forms.TextBox();
            this.txtNoInt = new System.Windows.Forms.TextBox();
            this.gbDireccion = new System.Windows.Forms.GroupBox();
            this.gbDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Postal";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(23, 43);
            this.txtCp.MaxLength = 5;
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(69, 20);
            this.txtCp.TabIndex = 0;
            this.txtCp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCp_KeyDown);
            this.txtCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCp_KeyPress);
            this.txtCp.Leave += new System.EventHandler(this.txtCp_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colonia";
            // 
            // cmbColonia
            // 
            this.cmbColonia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColonia.FormattingEnabled = true;
            this.cmbColonia.Location = new System.Drawing.Point(120, 42);
            this.cmbColonia.Name = "cmbColonia";
            this.cmbColonia.Size = new System.Drawing.Size(309, 21);
            this.cmbColonia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "No Exterior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "No Interior";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(23, 105);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(230, 20);
            this.txtCalle.TabIndex = 2;
            // 
            // txtNoExt
            // 
            this.txtNoExt.Location = new System.Drawing.Point(274, 105);
            this.txtNoExt.Name = "txtNoExt";
            this.txtNoExt.Size = new System.Drawing.Size(69, 20);
            this.txtNoExt.TabIndex = 3;
            this.txtNoExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoExt_KeyPress);
            // 
            // txtNoInt
            // 
            this.txtNoInt.Location = new System.Drawing.Point(360, 105);
            this.txtNoInt.Name = "txtNoInt";
            this.txtNoInt.Size = new System.Drawing.Size(69, 20);
            this.txtNoInt.TabIndex = 4;
            this.txtNoInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoInt_KeyPress);
            // 
            // gbDireccion
            // 
            this.gbDireccion.BackColor = System.Drawing.Color.White;
            this.gbDireccion.Controls.Add(this.label2);
            this.gbDireccion.Controls.Add(this.txtNoInt);
            this.gbDireccion.Controls.Add(this.label1);
            this.gbDireccion.Controls.Add(this.txtNoExt);
            this.gbDireccion.Controls.Add(this.txtCp);
            this.gbDireccion.Controls.Add(this.txtCalle);
            this.gbDireccion.Controls.Add(this.cmbColonia);
            this.gbDireccion.Controls.Add(this.label5);
            this.gbDireccion.Controls.Add(this.label3);
            this.gbDireccion.Controls.Add(this.label4);
            this.gbDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDireccion.ForeColor = System.Drawing.Color.MediumBlue;
            this.gbDireccion.Location = new System.Drawing.Point(0, 0);
            this.gbDireccion.Name = "gbDireccion";
            this.gbDireccion.Size = new System.Drawing.Size(455, 140);
            this.gbDireccion.TabIndex = 17;
            this.gbDireccion.TabStop = false;
            this.gbDireccion.Text = "Direccion";
            // 
            // UcDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDireccion);
            this.Name = "UcDireccion";
            this.Size = new System.Drawing.Size(455, 140);
            this.gbDireccion.ResumeLayout(false);
            this.gbDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColonia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNoExt;
        private System.Windows.Forms.TextBox txtNoInt;
        private System.Windows.Forms.GroupBox gbDireccion;
    }
}
