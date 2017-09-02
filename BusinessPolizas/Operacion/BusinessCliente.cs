using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Data.Model;
using Polizas.Entities.Clientes;

namespace Polizas.Business.Operacion
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
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                data.NoContrato = data.NoContrato.Trim();
                data.Nombre = data.Nombre.Trim();
                data.RepresentanteLegal = data.RepresentanteLegal.Trim();
                data.Rfc = data.Rfc.Trim();
                data.Correo = data.Correo.Trim().ToLower();
                data.FechaAlta = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff"), "yyyy-MM-dd HH:mm:ss:fff", CultureInfo.InvariantCulture);
                if (data.Id == 0)
                    db.Cliente.AddObject(data);
                db.SaveChanges();
                new DropBoxManager().CreateFolder(data.Nombre);
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
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.OrderBy(o => o.Nombre).ToList();
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
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                string[] words = filtro.Split(' ');
                result = new List<Cliente>();
                foreach (string word in words)
                {
                    result.AddRange(db.Cliente.Where(w => w.Nombre.Contains(word)).OrderBy(o => o.Nombre).ToList());
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
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cliente.SingleOrDefault(s => s.Id == id);
                if (result != null)
                {
                    db.LoadProperty(result, "ClienteDireccion");
                    foreach (ClienteDireccion direccion in result.ClienteDireccion)
                    {
                        db.LoadProperty(direccion, "Colonia");
                        db.LoadProperty(direccion.Colonia, "Municipio");
                        db.LoadProperty(direccion.Colonia.Municipio, "Estado");
                        db.LoadProperty(direccion.Colonia.Municipio.Estado, "Pais");
                    }
                    db.LoadProperty(result, "ClienteTelefono");
                    foreach (ClienteTelefono telefono in result.ClienteTelefono)
                    {
                        db.LoadProperty(telefono, "TipoTelefono");
                    }
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
