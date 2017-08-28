using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities;

namespace Polizas.Business.Catalogos
{
    public class BusinessTipoTelefono
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessTipoTelefono(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<TipoTelefono> ObtenerTiposTelefono(bool insertaSeleccion)
        {
            List<TipoTelefono> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.TipoTelefono.Where(w => w.Habilitado).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new TipoTelefono
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
