using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Catalogos;

namespace Polizas.Business.Sistema
{
    public class BusinessTipoPoliza
    {
        private bool _proxy;
        public BusinessTipoPoliza(bool proxy = false)
        {
            _proxy = proxy;
        }

        public void Dispose()
        { }
        public List<TipoPoliza> ObtenerMediosPublicidad(bool insertarSeleccion)
        {
            List<TipoPoliza> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.TipoPoliza.Where(w => w.Habilitado)
                        .OrderBy(o => o.Descripcion)
                        .ToList();
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new TipoPoliza 
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
