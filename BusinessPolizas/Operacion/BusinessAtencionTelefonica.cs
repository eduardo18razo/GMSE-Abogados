using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities;
using Polizas.Entities.Clientes;

namespace Polizas.Business.Operacion
{
    public class BusinessAtencionTelefonica
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessAtencionTelefonica(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool Guardar(AtencionTelefonica data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                data.Cliente.FechaAlta = DateTime.Now;
                data.FechaHoraContacto = DateTime.Now;
                if (data.Id == 0)
                    db.AtencionTelefonica.AddObject(data);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                if (data.Id != 0)
                    db.AtencionTelefonica.DeleteObject(data);
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public List<AtencionTelefonica> ObtenerArrendatarios(bool insertarSeleccion)
        {
            List<AtencionTelefonica> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.AtencionTelefonica.OrderBy(o => o.Cliente.Nombre).ToList();
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new AtencionTelefonica
                        {
                            Id = BusinessVariables.ComboBoxCatalogo.ValueSeleccione,
                            Cliente = new Cliente { Nombre = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione }
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

        public List<AtencionTelefonica> BuscarArrendatarios(string filtro)
        {
            List<AtencionTelefonica> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<AtencionTelefonica>();
                foreach (string word in words)
                {
                    result.AddRange(db.AtencionTelefonica.Where(w => w.Cliente.Nombre.Contains(word)).OrderBy(o => o.Cliente.Nombre).ToList());
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

        public AtencionTelefonica ObtenerArrendatario(int id)
        {
            AtencionTelefonica result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.AtencionTelefonica.SingleOrDefault(s => s.Id == id);
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
