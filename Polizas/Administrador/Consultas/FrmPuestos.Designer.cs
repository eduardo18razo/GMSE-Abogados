namespace Polizas.Administrador.Consultas
{
    partial class FrmPuestos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gvPuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(259, 235);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gvPuestos
            // 
            this.gvPuestos.AllowUserToAddRows = false;
            this.gvPuestos.AllowUserToDeleteRows = false;
            this.gvPuestos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPuestos.Location = new System.Drawing.Point(12, 12);
            this.gvPuestos.Name = "gvPuestos";
            this.gvPuestos.ReadOnly = true;
            this.gvPuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPuestos.Size = new System.Drawing.Size(322, 217);
            this.gvPuestos.TabIndex = 4;
            this.gvPuestos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPuestos_CellDoubleClick);
            // 
            // FrmPuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 270);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gvPuestos);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.MaximumSize = new System.Drawing.Size(362, 309);
            this.MinimumSize = new System.Drawing.Size(362, 309);
            this.Name = "FrmPuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPuestos";
            this.Load += new System.EventHandler(this.FrmPuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView gvPuestos;
    }
}