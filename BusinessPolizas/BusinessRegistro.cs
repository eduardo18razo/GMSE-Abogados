using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities.Clientes;

namespace Polizas.Business
{
    public class BusinessRegistro
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessRegistro(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool GuardarRegistro(Cliente data)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (data.Id == 0)
                    db.Cliente.AddObject(data);
                db.SaveChanges();
                new DocumentManager().GenerateDocx(data);
            }
            catch (Exception ex)
            {
                if (data.Id != 0)
                    db.Cliente.DeleteObject(data);
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public List<Cliente> ObtenerRegistros(bool insertarSeleccion)
        {
            List<Cliente> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.OrderBy(o => o.Nombre).ToList();
                foreach (Cliente registro in result)
                {
                    db.LoadProperty(registro, "UsuarioAlta");
                    db.LoadProperty(registro, "UsuarioModifico");
                }
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Cliente
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

        public List<Cliente> BuscarRegistro(string filtro)
        {
            List<Cliente> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<Cliente>();
                foreach (string word in words)
                {
                    result.AddRange(db.Cliente.Where(w => w.Nombre.Contains(word)).OrderBy(o => o.Nombre).ToList());
                }
                foreach (Cliente registro in result)
                {
                    db.LoadProperty(registro, "UsuarioAlta");
                    db.LoadProperty(registro, "UsuarioModifico");
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

        public Cliente ObtenerRegistro(int id)
        {
            Cliente result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.SingleOrDefault(s => s.Id == id);
                if(result != null)
                {
                    db.LoadProperty(result, "UsuarioAlta");
                    db.LoadProperty(result, "UsuarioModifico");
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
    }
}
