using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polizas.Data.Model;
using Polizas.Entities.Ubicacion;

namespace Polizas.Business
{
    public class BusinessColonia
    {
        private bool _proxy;
        public BusinessColonia(bool proxy = false)
        {
            _proxy = proxy;
        }

        public void Dispose()
        { }

        public List<Colonia> ObtenerColoniasCp(int cp, bool insertarSeleccion)
        {
            List<Colonia> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Colonia.Where(w => w.CP == cp).OrderBy(o => o.Descripcion).ToList();
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione, new Colonia { Id = BusinessVariables.ComboBoxCatalogo.ValueSeleccione, Descripcion = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione });
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
