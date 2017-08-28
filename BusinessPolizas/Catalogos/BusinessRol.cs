using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Roles;

namespace Polizas.Business.Catalogos
{
    public class BusinessRol
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessRol(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool CrearRol(Rol data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (db.Rol.Any(a => a.Descripcion == data.Descripcion.Trim() && a.Id != data.Id))
                    throw new Exception("Ya Existe un registro con esta descripción");
                if (data.Id == 0)
                    db.Rol.AddObject(data);
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
        public bool Actualizar(Rol data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (db.Rol.Any(a => a.Descripcion == data.Descripcion.Trim() && a.Id != data.Id))
                    throw new Exception("Ya Existe un registro con esta descripción");
                Rol rol = db.Rol.SingleOrDefault(s => s.Id == data.Id);
                if (rol != null)
                {
                    rol.Descripcion = data.Descripcion;
                }
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
        public List<Rol> ObtenerRoles(bool insertaSeleccion)
        {
            List<Rol> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Rol.Where(w => w.Habilitado).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Rol
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
        public Rol ObtenerRol(int id)
        {
            Rol result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Rol.SingleOrDefault(w => w.Id == id);
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

        public List<Pantalla> ObtenerMenus(bool insertaSeleccion)
        {
            List<Pantalla> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Pantalla.Where(w => (bool)w.EsMenu && w.IdPadre == null).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Pantalla
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
        public List<Pantalla> ObtenerPantallas(bool insertaSeleccion)
        {
            List<Pantalla> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Pantalla.Where(w => !(bool)w.EsMenu && w.IdPadre != null).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Pantalla
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

        public List<RolPantalla> ObtenerRolPantalla(int idRol)
        {
            List<RolPantalla> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.RolPantalla.Where(w => w.IdRol == idRol).ToList();
                foreach (RolPantalla rolPantalla in result)
                {
                    db.LoadProperty(rolPantalla, "Rol");
                    db.LoadProperty(rolPantalla, "Pantalla");
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

        public bool CrearRolPantalla(List<RolPantalla> data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                foreach (RolPantalla rolPantalla in data)
                {
                    if (!db.RolPantalla.Any(a => a.IdRol == rolPantalla.IdRol && a.IdPantalla != rolPantalla.IdPantalla))
                        db.RolPantalla.AddObject(rolPantalla);
                }
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
    }
}
