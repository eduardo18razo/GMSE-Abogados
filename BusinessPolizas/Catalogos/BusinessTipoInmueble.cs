using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities;
using Polizas.Entities.Inmueble;

namespace Polizas.Business.Catalogos
{
    public class BusinessTipoInmueble
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessTipoInmueble(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<TipoInmueble> ObtenerTiposInmueble(bool insertaSeleccion)
        {
            List<TipoInmueble> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.TipoInmueble.Where(w => w.Habilitado).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new TipoInmueble
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
