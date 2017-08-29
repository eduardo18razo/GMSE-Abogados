using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Inmueble;

namespace Polizas.Business.Sistema
{
    public class BusinessTipoUso
    {
        private bool _proxy;
        public BusinessTipoUso(bool proxy = false)
        {
            _proxy = proxy;
        }

        public void Dispose()
        { }
        public List<TipoUso> ObtenerMediosPublicidad(bool insertarSeleccion)
        {
            List<TipoUso> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.TipoUso.Where(w => w.Habilitado)
                        .OrderBy(o => o.Descripcion)
                        .ToList();
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new TipoUso
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
