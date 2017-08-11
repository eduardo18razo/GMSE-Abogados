using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Data.Model;
using Polizas.Entities;

namespace Polizas.Business
{
    public class BusinessCita
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessCita(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool CrearCita(Cita newDate)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (newDate.Id == 0)
                    db.Cita.AddObject(newDate);
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

        public bool ActualizarCita(Cita newDate)
        {
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                Cita oldDate = db.Cita.SingleOrDefault(s => s.Id == newDate.Id);
                if (oldDate != null)
                {
                    oldDate.Text = newDate.Text;
                    oldDate.StartDate = newDate.StartDate;
                    oldDate.EndDate = newDate.EndDate;
                    oldDate.BorderColor = newDate.BorderColor;
                    oldDate.IdUsuario = newDate.IdUsuario;
                    oldDate.IdCliente = newDate.IdCliente;
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

        public List<Cita> ObtenerCitas()
        {
            List<Cita> result;
            PolizasModelContextBase db = new PolizasModelContextBase();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Cita.OrderBy(o => o.StartDate).ToList();
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
