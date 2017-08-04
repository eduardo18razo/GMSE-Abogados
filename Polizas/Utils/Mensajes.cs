using System.Windows.Forms;

namespace Polizas.Utils
{
    public static class Mensajes
    {
        public static DialogResult Error(string mensaje, string titulo = "Polizas Juridicas")
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Exito(string titulo, string mensaje = "")
        {
            return MessageBox.Show(mensaje.Trim() == string.Empty ? "Registro guardado con exito" : mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Exclamacion(string mensaje, string titulo = "Polizas Juridicas")
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static bool Confirmacion(string mensaje, string titulo = "Polizas Juridicas")
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes;
        }
    }
}
