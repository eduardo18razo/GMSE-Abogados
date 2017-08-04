using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities;

namespace Polizas.Business
{
    public class BusinessUsuario
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessUsuario(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool GuardarUsuario(Usuario data)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                data.Password = BusinessSecurity.CreateShaHash(data.Password);
                if (data.Id == 0)
                    db.Usuario.AddObject(data);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public Usuario ObtenerUsuario(int id)
        {
            Usuario result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.SingleOrDefault(w => w.Id == id);
                if (result != null)
                {
                    db.LoadProperty(result, "Rol");
                }
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

        public List<Usuario> ObtenerRegistros(bool insertarSeleccion)
        {
            List<Usuario> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.OrderBy(o => o.Nombre).ToList();
                foreach (Usuario usuario in result)
                {
                    db.LoadProperty(usuario, "Rol");
                }
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Usuario
                        {
                            Id = BusinessVariables.ComboBoxCatalogo.ValueSeleccione,
                            Nombre = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione
                        });
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

        public List<Usuario> BuscarRegistro(string nombre)
        {
            List<Usuario> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.Where(w => w.Nombre.Contains(nombre)).OrderBy(o => o.Nombre).ToList();
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
