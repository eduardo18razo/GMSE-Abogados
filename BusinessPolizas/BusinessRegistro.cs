using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities;

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

        public bool GuardarRegistro(Registro data)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (data.Id == 0)
                    db.Registros.AddObject(data);
                db.SaveChanges();
                new DocumentManager().GenerateDocx(data);
            }
            catch (Exception ex)
            {
                if (data.Id != 0)
                    db.Registros.DeleteObject(data);
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public List<Registro> ObtenerRegistros(bool insertarSeleccion)
        {
            List<Registro> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Registros.OrderBy(o => o.Nombre).ToList();
                foreach (Registro registro in result)
                {
                    db.LoadProperty(registro, "UsuarioAlta");
                    db.LoadProperty(registro, "UsuarioModifico");
                }
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Registro
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

        public List<Registro> BuscarRegistro(string filtro)
        {
            List<Registro> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<Registro>();
                foreach (string word in words)
                {
                    result.AddRange(db.Registros.Where(w => w.Nombre.Contains(word)).OrderBy(o => o.Nombre).ToList());
                }
                foreach (Registro registro in result)
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

        public Registro ObtenerRegistro(int id)
        {
            Registro result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Registros.SingleOrDefault(s => s.Id == id);
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
