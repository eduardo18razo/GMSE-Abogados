using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Usuarios;

namespace Polizas.Business.Catalogos
{
    public class BusinessPuesto
    {
        private readonly bool _proxy;
        public void Dispose()
        {

        }
        public BusinessPuesto(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<Puesto> ObtenerPuestos(bool insertarSeleccion)
        {
            List<Puesto> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Puesto.Where(w => w.Habilitado).OrderBy(o => o.Descripcion).ToList();

                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Puesto
                        {
                            Id = BusinessVariables.ComboBoxCatalogo.ValueSeleccione,
                            Descripcion = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione
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
        public Puesto ObtenerPuestoById(int idPuesto)
        {
            Puesto result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Puesto.SingleOrDefault(w => w.Id == idPuesto && w.Habilitado);
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

        public void Guardar(Puesto puesto)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                puesto.Habilitado = true;
                puesto.Descripcion = puesto.Descripcion.Trim();
                if (db.Puesto.Any(a => a.Descripcion == puesto.Descripcion))
                    throw new Exception("Este Puesto ya existe.");
                if (puesto.Id == 0)
                    db.Puesto.AddObject(puesto);
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
        }

        public void Actualizar(Puesto puesto)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                if (db.Puesto.Any(a => a.Descripcion == puesto.Descripcion && a.Id != puesto.Id))
                    throw new Exception("Este Puesto ya existe.");
                db.ContextOptions.LazyLoadingEnabled = true;
                Puesto pto = db.Puesto.SingleOrDefault(s => s.Id == puesto.Id);

                if (pto == null) return;
                pto.Descripcion = puesto.Descripcion.Trim();

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
        }

        public List<Puesto> ObtenerPuestoConsulta()
        {
            List<Puesto> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {

                db.ContextOptions.ProxyCreationEnabled = _proxy;
                IQueryable<Puesto> qry = db.Puesto;
                result = qry.OrderBy(o => o.Descripcion).ToList();
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

        public void Habilitar(int idPuesto, bool habilitado)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                Puesto inf = db.Puesto.SingleOrDefault(w => w.Id == idPuesto);
                if (inf != null) inf.Habilitado = habilitado;
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
        }
    }
}
