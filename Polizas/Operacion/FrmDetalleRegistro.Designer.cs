namespace Polizas.Operacion
{
    partial class FrmDetalleRegistro
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
            this.flpDoctos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpDoctos
            // 
            this.flpDoctos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDoctos.AutoScroll = true;
            this.flpDoctos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpDoctos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDoctos.Location = new System.Drawing.Point(457, 27);
            this.flpDoctos.Name = "flpDoctos";
            this.flpDoctos.Size = new System.Drawing.Size(279, 506);
            this.flpDoctos.TabIndex = 0;
            this.flpDoctos.WrapContents = false;
            // 
            // FrmDetalleRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(748, 545);
            this.Controls.Add(this.flpDoctos);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MinimumSize = new System.Drawing.Size(764, 584);
            this.Name = "FrmDetalleRegistro";
            this.Text = "FrmDetalleRegistro";
            this.Load += new System.EventHandler(this.FrmDetalleRegistro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDoctos;
    }
}