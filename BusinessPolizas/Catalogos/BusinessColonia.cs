using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Ubicacion;

namespace Polizas.Business.Catalogos
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
            PolizasModelContext db = new PolizasModelContext();
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

        public Colonia ObtenerColonia(int idColonia)
        {
            Colonia result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Colonia.SingleOrDefault(w => w.Id == idColonia);
                if (result != null)
                {
                    db.LoadProperty(result, "Municipio");
                    db.LoadProperty(result.Municipio, "Estado");
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
    }
}
