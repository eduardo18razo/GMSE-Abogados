using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Arrendatario;

namespace Polizas.Business.Operacion
{
    public class BusinessArrendatario
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessArrendatario(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool GuardarArrendatario(Arrendatario data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (data.Id == 0)
                    db.Arrendatario.AddObject(data);
                db.SaveChanges();
                new DropBoxManager().CreateFolder(data.Nombre);
            }
            catch (Exception ex)
            {
                if (data.Id != 0)
                    db.Arrendatario.DeleteObject(data);
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public List<Arrendatario> ObtenerArrendatarios(bool insertarSeleccion)
        {
            List<Arrendatario> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Arrendatario.OrderBy(o => o.Nombre).ToList();
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Arrendatario
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

        public List<Arrendatario> BuscarArrendatarios(string filtro)
        {
            List<Arrendatario> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<Arrendatario>();
                foreach (string word in words)
                {
                    result.AddRange(db.Arrendatario.Where(w => w.Nombre.Contains(word)).OrderBy(o => o.Nombre).ToList());
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

        public Arrendatario ObtenerArrendatario(int id)
        {
            Arrendatario result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Arrendatario.SingleOrDefault(s => s.Id == id);
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
