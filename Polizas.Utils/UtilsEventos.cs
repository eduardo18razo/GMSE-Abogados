using System;
using System.Windows.Forms;

namespace Polizas.Utils
{
    public class UtilsEventos
    {
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se aceptan Numeros");
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
