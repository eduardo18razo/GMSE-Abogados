﻿namespace Polizas.Temporales
{
    partial class FrmConfiguracionTemplate
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
            this.lbxMarcadores = new System.Windows.Forms.ListBox();
            this.ofdTemplate = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxMarcadores
            // 
            this.lbxMarcadores.FormattingEnabled = true;
            this.lbxMarcadores.Location = new System.Drawing.Point(12, 105);
            this.lbxMarcadores.Name = "lbxMarcadores";
            this.lbxMarcadores.Size = new System.Drawing.Size(190, 316);
            this.lbxMarcadores.TabIndex = 0;
            this.lbxMarcadores.DoubleClick += new System.EventHandler(this.lbxMarcadores_DoubleClick);
            // 
            // ofdTemplate
            // 
            this.ofdTemplate.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdTemplate_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 316);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmConfiguracionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxMarcadores);
            this.Name = "FrmConfiguracionTemplate";
            this.Text = "FrmConfiguracionTemplate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMarcadores;
        private System.Windows.Forms.OpenFileDialog ofdTemplate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}