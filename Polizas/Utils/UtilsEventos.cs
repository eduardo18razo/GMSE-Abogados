using System;
using System.Windows.Forms;

namespace Polizas.Utils
{
    public static class UtilsEventos
    {
        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                    throw new Exception("Solo se aceptan Numeros");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Numero2Decimales(object sender, KeyPressEventArgs e)
        {
            try
            {
                TextBox txt = (TextBox)sender;
                if (txt == null) return;
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec = 0;

                foreach (char t in txt.Text)
                {
                    if (t == '.')
                        IsDec = true;

                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }

                if (e.KeyChar >= 48 && e.KeyChar <= 57)
                    e.Handled = false;
                else if (e.KeyChar == 46)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
