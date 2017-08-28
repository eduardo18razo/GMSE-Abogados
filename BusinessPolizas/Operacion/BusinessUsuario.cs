using System;
using System.Collections.Generic;
using System.Linq;
using Polizas.Business.Manager;
using Polizas.Business.Sistema;
using Polizas.Data.Model;
using Polizas.Entities.Usuarios;

namespace Polizas.Business.Operacion
{
    public class BusinessUsuario
    {
        private bool _proxy;
        public void Dispose()
        {

        }
        public BusinessUsuario(bool proxy = false)
        {
            _proxy = proxy;
        }

        public bool Guardar(Usuario data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                data.Password = BusinessSecurity.CreateShaHash(data.Password);
                if (data.Id == 0)
                    db.Usuario.AddObject(data);
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

        public bool Actualizar(Usuario data)
        {
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                Usuario user = db.Usuario.SingleOrDefault(s => s.Id == data.Id);
                if (user != null)
                {
                    user.Nombre = data.Nombre;
                    user.IdPuesto = data.IdPuesto;
                    user.Correo = data.Correo;
                    user.NombreUsuario = data.NombreUsuario;
                    user.UsuarioDireccion = user.UsuarioDireccion ?? new List<UsuarioDireccion>();
                    user.UsuarioTelefono = user.UsuarioTelefono ?? new List<UsuarioTelefono>();

                    foreach (UsuarioRol rol in data.UsuarioRol)
                    {
                        if (!db.UsuarioRol.Any(a => a.IdRol == rol.IdRol && a.IdUsuario == user.Id))
                            db.UsuarioRol.AddObject(new UsuarioRol { IdRol = rol.IdRol, IdUsuario = user.Id });
                    }

                    if (user.UsuarioDireccion.Any())
                    {
                        user.UsuarioDireccion.First().IdColonia = data.UsuarioDireccion.First().IdColonia;
                        user.UsuarioDireccion.First().Calle = data.UsuarioDireccion.First().Calle;
                        user.UsuarioDireccion.First().NoExt = data.UsuarioDireccion.First().NoExt;
                        user.UsuarioDireccion.First().NoInt = data.UsuarioDireccion.First().NoInt;
                    }
                    else
                        user.UsuarioDireccion = data.UsuarioDireccion;
                    if (user.UsuarioTelefono.Any())
                    {
                        foreach (UsuarioTelefono telefono in user.UsuarioTelefono)
                        {
                            db.UsuarioTelefono.DeleteObject(telefono);
                        }
                    }
                    user.UsuarioTelefono = data.UsuarioTelefono;

                    db.SaveChanges();
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
            return true;
        }

        public Usuario ObtenerUsuario(int id)
        {
            Usuario result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.SingleOrDefault(w => w.Id == id);
                if (result != null)
                {
                    db.LoadProperty(result, "Puesto");
                    db.LoadProperty(result, "UsuarioRol");
                    db.LoadProperty(result, "UsuarioDireccion");
                    db.LoadProperty(result, "UsuarioTelefono");
                    foreach (UsuarioRol rol in result.UsuarioRol)
                    {
                        db.LoadProperty(rol, "Rol");
                        db.LoadProperty(rol.Rol, "RolPantalla");
                    }
                    foreach (UsuarioDireccion direccion in result.UsuarioDireccion)
                    {
                        db.LoadProperty(direccion, "Colonia");
                        db.LoadProperty(direccion.Colonia, "Municipio");
                        db.LoadProperty(direccion.Colonia.Municipio, "Estado");
                        db.LoadProperty(direccion.Colonia.Municipio.Estado, "Pais");
                    }
                    foreach (UsuarioTelefono telefono in result.UsuarioTelefono)
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

        public List<Usuario> ObtenerUsuarios(bool insertarSeleccion)
        {
            List<Usuario> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.OrderBy(o => o.Nombre).ToList();
                foreach (Usuario usuario in result)
                {
                    db.LoadProperty(usuario, "Puesto");
                    db.LoadProperty(usuario, "UsuarioRol");
                    db.LoadProperty(usuario, "UsuarioDireccion");
                    db.LoadProperty(usuario, "UsuarioTelefono");
                    foreach (UsuarioRol rol in usuario.UsuarioRol)
                    {
                        db.LoadProperty(rol, "Rol");
                        db.LoadProperty(rol.Rol, "RolPantalla");
                    }
                    foreach (UsuarioDireccion direccion in usuario.UsuarioDireccion)
                    {
                        db.LoadProperty(direccion, "Colonia");
                        db.LoadProperty(direccion.Colonia, "Municipio");
                        db.LoadProperty(direccion.Colonia.Municipio, "Estado");
                        db.LoadProperty(direccion.Colonia.Municipio.Estado, "Pais");
                    }
                    foreach (UsuarioTelefono telefono in usuario.UsuarioTelefono)
                    {
                        db.LoadProperty(telefono, "TipoTelefono");
                    }

                }
                if (insertarSeleccion)
                    result.Insert(BusinessVariables.ComboBoxCatalogo.IndexSeleccione,
                        new Usuario
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

        public List<Usuario> BuscarUsuarios(string nombre)
        {
            List<Usuario> result;
            PolizasModelContext db = new PolizasModelContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Usuario.Where(w => w.Nombre.Contains(nombre)).OrderBy(o => o.Nombre).ToList();
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
