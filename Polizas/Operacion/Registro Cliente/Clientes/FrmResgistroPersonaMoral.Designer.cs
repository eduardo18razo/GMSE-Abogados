using Polizas.UserControls;

namespace Polizas.Operacion.Clientes
{
    partial class FrmRegistroPersonaMoral
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
            this.SuspendLayout();
            // 
            // FrmRegistroPersonaMoral
            // 
            this.ClientSize = new System.Drawing.Size(462, 343);
            this.Name = "FrmRegistroPersonaMoral";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerardocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtCorreo;
        private UcDireccion ucDireccion1;
    }
}

