using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities.Clientes;

namespace Polizas.Business
{
    public class BusinessCliente
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessCliente(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool GuardarCliente(Cliente data)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                System.Globalization.CultureInfo enUS = new System.Globalization.CultureInfo("en-US");
                DateTime paramFromDate;
                DateTime paramToDate;
                string StartDate = "07/01/2015";
                string EndDate = "07/30/2015";
                Boolean goodStartDate = false;
                Boolean goodEndDate = false;
                goodStartDate
                    = DateTime.TryParseExact(StartDate, "MM/dd/yyyy", enUS,
                                             System.Globalization.DateTimeStyles.None,
                                             out paramFromDate);
                goodEndDate
                    = DateTime.TryParseExact(EndDate, "MM/dd/yyyy", enUS,
                                             System.Globalization.DateTimeStyles.None,
                                             out paramToDate);
                if (goodStartDate) Console.WriteLine(paramFromDate);
                if (goodEndDate) Console.WriteLine(paramToDate);
                if (goodStartDate && goodEndDate)
                {
                    String FromDate
                        = paramFromDate.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                                 System.Globalization.CultureInfo.InvariantCulture);
                    String ToDate
                        = paramToDate.ToString("yyyy-MM-dd HH:mm:ss.fff",
                                               System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine(FromDate);
                    Console.WriteLine(ToDate);
                }

                db.ContextOptions.ProxyCreationEnabled = _proxy;
                data.FechaAlta = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "yyyy-MM-dd HH:mm:ss:fff", CultureInfo.InvariantCulture);
                if (data.Id == 0)
                    db.Cliente.AddObject(data);
                db.SaveChanges();
                new DocumentManager().GenerateDocx(data);
            }
            catch (Exception ex)
            {
                if (data.Id != 0)
                    db.Cliente.DeleteObject(data);
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return true;
        }

        public List<Cliente> ObtenerClientes(bool insertarSeleccion)
        {
            List<Cliente> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.OrderBy(o => o.Nombre).ToList();
                foreach (Cliente registro in result)
                {
                    db.LoadProperty(registro, "UsuarioAlta");
                    db.LoadProperty(registro, "UsuarioModifico");
                }
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Cliente
                        {
                            Id = BusinessVariables.ComboBoxCatalogo.ValueSeleccione,
                            Nombre = BusinessVariables.ComboBoxCatalogo.DescripcionSeleccione
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

        public List<Cliente> BuscarClientes(string filtro)
        {
            List<Cliente> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<Cliente>();
                foreach (string word in words)
                {
                    result.AddRange(db.Cliente.Where(w => w.Nombre.Contains(word)).OrderBy(o => o.Nombre).ToList());
                }
                foreach (Cliente registro in result)
                {
                    db.LoadProperty(registro, "UsuarioAlta");
                    db.LoadProperty(registro, "UsuarioModifico");
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

        public Cliente ObtenerCliente(int id)
        {
            Cliente result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.SingleOrDefault(s => s.Id == id);
                if (result != null)
                {
                    db.LoadProperty(result, "UsuarioAlta");
                    db.LoadProperty(result, "UsuarioModifico");
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
