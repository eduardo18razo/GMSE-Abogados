using System;
using System.Linq;
using System.Text;
using Polizas.Data.Model;
using Polizas.Entities.Usuarios;

namespace Polizas.Business
{
    public class BusinessSecurity : IDisposable
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessSecurity(bool proxy = false)
        {
            _proxy = proxy;
        }

        public static string CreateShaHash(string cadena)
        {
            System.Security.Cryptography.SHA512Managed hashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] cadenaAsByte = Encoding.UTF8.GetBytes(cadena);
            Byte[] encryptedBytes = hashTool.ComputeHash(cadenaAsByte);
            hashTool.Clear();
            return Convert.ToBase64String(encryptedBytes);
        }

        public Usuario AutenticarUsuario(string username, string psw)
        {
            Usuario result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                string hashedPdw = CreateShaHash(psw);
                result = db.Usuario.FirstOrDefault(w => w.NombreUsuario == username && w.Password == hashedPdw && w.Habilitado);
                if (result == null)
                    throw new Exception("Usuairo y/o contraseña incorrectos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }
    }
}
