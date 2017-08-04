namespace Polizas.Operacion
{
    partial class UsrCtrlFile
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
            this.lnkFileName = new System.Windows.Forms.LinkLabel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkFileName
            // 
            this.lnkFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkFileName.Location = new System.Drawing.Point(4, 14);
            this.lnkFileName.Name = "lnkFileName";
            this.lnkFileName.Size = new System.Drawing.Size(77, 18);
            this.lnkFileName.TabIndex = 0;
            this.lnkFileName.TabStop = true;
            this.lnkFileName.Text = "linkLabel1";
            this.lnkFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFileName_LinkClicked);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(87, 9);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // UsrCtrlFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lnkFileName);
            this.Name = "UsrCtrlFile";
            this.Size = new System.Drawing.Size(176, 37);
            this.Load += new System.EventHandler(this.UsrCtrlFile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkFileName;
        private System.Windows.Forms.Button btnImprimir;
    }
}
