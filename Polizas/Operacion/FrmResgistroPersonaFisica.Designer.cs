namespace Polizas.Operacion
{
    partial class frmRegistroPersonaFisica
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
            this.SuspendLayout();
            // 
            // btnGenerardocumento
            // 
            this.btnGenerardocumento.Location = new System.Drawing.Point(611, 498);
            this.btnGenerardocumento.Name = "btnGenerardocumento";
            this.btnGenerardocumento.Size = new System.Drawing.Size(125, 23);
            this.btnGenerardocumento.TabIndex = 0;
            this.btnGenerardocumento.Text = "Generar Documentos";
            this.btnGenerardocumento.UseVisualStyleBackColor = true;
            this.btnGenerardocumento.Click += new System.EventHandler(this.btnGenerarDocumento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // dpFecha
            // 
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(63, 60);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(323, 20);
            this.dpFecha.TabIndex = 5;
            // 
            // frmRegistroPersonaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 545);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerardocumento);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MinimumSize = new System.Drawing.Size(764, 584);
            this.Name = "frmRegistroPersonaFisica";
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
    }
}

