using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities;
using Polizas.Entities.Roles;

namespace Polizas.Business
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

        public List<Rol> ObtenerRoles(bool insertaSeleccion)
        {
            List<Rol> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
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
    }
}
