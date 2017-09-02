
using System;
using System.Data.EntityClient;
using System.Data.Objects;
using Polizas.Entities;
using Polizas.Entities.Arrendatario;
using Polizas.Entities.Catalogos;
using Polizas.Entities.Clientes;
using Polizas.Entities.Inmueble;
using Polizas.Entities.Roles;
using Polizas.Entities.Ubicacion;
using Polizas.Entities.Usuarios;

namespace Polizas.Data.Model
{
    public partial class PolizasModelContext : ObjectContext
    {
        private readonly EntityConnection _connection;
        private readonly string _connectionString;
        private const string ConnectionString = "name=PolizasEntities";
        private const string ContainerName = "PolizasEntities";
        
        #region Private vars
        //Region Finales
        //Generales
        private readonly ObjectSet<Pais> _pais;
        private readonly ObjectSet<Estado> _estado;
        private readonly ObjectSet<Municipio> _municipio;
        private readonly ObjectSet<Colonia> _colonia;
        private readonly ObjectSet<TipoTelefono> _tipoTelefono;


        //Arrendatario
        private readonly ObjectSet<Arrendatario> _arrendatario;
        private readonly ObjectSet<ArrendatarioDireccion> _arrendatarioDireccion;
        private readonly ObjectSet<ArrendatarioTelefono> _arrendatarioTelefono;

        //Cliente
        private readonly ObjectSet<Cliente> _cliente;
        private readonly ObjectSet<ClienteDireccion> _clienteDireccion;
        private readonly ObjectSet<ClienteTelefono> _clienteTelefono;
        private readonly ObjectSet<AtencionTelefonica> _atencionTelefonica; 

        //Catalogos
        private readonly ObjectSet<MedioPublicidad> _medioContacto;
        private readonly ObjectSet<TipoPoliza> _tipoPoliza;
        private readonly ObjectSet<TipoUso> _tipoUso;
        private readonly ObjectSet<TipoInmueble> _tipoinmueble; 

        //Region Sin Utilizar
        private readonly ObjectSet<Cita> _cita;
        private readonly ObjectSet<Pantalla> _pantalla;
        private readonly ObjectSet<Puesto> _puesto;
        private readonly ObjectSet<Rol> _rol;
        private readonly ObjectSet<RolPantalla> _rolPantalla;

        private readonly ObjectSet<Usuario> _usuario;
        private readonly ObjectSet<UsuarioDireccion> _usuarioDireccion;
        private readonly ObjectSet<UsuarioRol> _usuarioRol;
        private readonly ObjectSet<UsuarioTelefono> _usuarioTelefono;
        #endregion Private vars

        #region Public Properties
        //Region Finales
        //Generales
        public ObjectSet<Pais> Pais
        {
            get { return _pais; }
        }
        public ObjectSet<Estado> Estado
        {
            get { return _estado; }
        }

        public ObjectSet<Municipio> Municipio
        {
            get { return _municipio; }
        }
        public ObjectSet<Colonia> Colonia
        {
            get { return _colonia; }
        }
        public ObjectSet<TipoTelefono> TipoTelefono
        {
            get { return _tipoTelefono; }
        }

        //Arrendatario
        public ObjectSet<Arrendatario> Arrendatario
        {
            get { return _arrendatario; }
        }
        public ObjectSet<ArrendatarioDireccion> ArrendatarioDireccion
        {
            get { return _arrendatarioDireccion; }
        }
        public ObjectSet<ArrendatarioTelefono> ArrendatarioTelefono
        {
            get { return _arrendatarioTelefono; }
        }
        
        //Cliente

        //Region Sin Utilizar
        public ObjectSet<Cliente> Cliente
        {
            get { return _cliente; }
        }
        public ObjectSet<Cita> Cita
        {
            get { return _cita; }
        }
        public ObjectSet<ClienteDireccion> ClienteDireccion
        {
            get { return _clienteDireccion; }
        }
        public ObjectSet<ClienteTelefono> ClienteTelefono
        {
            get { return _clienteTelefono; }
        }
        public ObjectSet<Pantalla> Pantalla
        {
            get { return _pantalla; }
        }
        public ObjectSet<Puesto> Puesto
        {
            get { return _puesto; }
        }
        public ObjectSet<Rol> Rol
        {
            get { return _rol; }
        }
        public ObjectSet<RolPantalla> RolPantalla
        {
            get { return _rolPantalla; }
        }
        public ObjectSet<Usuario> Usuario
        {
            get { return _usuario; }
        }
        public ObjectSet<UsuarioDireccion> UsuarioDireccion
        {
            get { return _usuarioDireccion; }
        }
        public ObjectSet<UsuarioRol> UsuarioRol
        {
            get { return _usuarioRol; }
        }
        public ObjectSet<UsuarioTelefono> UsuarioTelefono
        {
            get { return _usuarioTelefono; }
        }

        public ObjectSet<AtencionTelefonica> AtencionTelefonica
        {
            get { return _atencionTelefonica; }
        }

        //Catalogos
        public ObjectSet<MedioPublicidad> MedioPublicidad
        {
            get { return _medioContacto; }
        }

        public ObjectSet<TipoPoliza> TipoPoliza
        {
            get { return _tipoPoliza; }
        }

        public ObjectSet<TipoUso> TipoUso
        {
            get { return _tipoUso; }
        }
        public ObjectSet<TipoInmueble> TipoInmueble
        {
            get { return _tipoinmueble; }
        }

        #endregion Public Properties
        
        public PolizasModelContext(EntityConnection connection) : base(connection)
        {   
        }

        public PolizasModelContext(string connectionString) : base(connectionString)
        {
        }

        protected PolizasModelContext(string connectionString, string defaultContainerName) : base(connectionString, defaultContainerName)
        {
            }

        protected PolizasModelContext(EntityConnection connection, string defaultContainerName) : base(connection, defaultContainerName)
        {
        }

        public PolizasModelContext()
            : base(ConnectionString, ContainerName)
        {
            try
            {
                //Generales
                _pais = CreateObjectSet<Pais>();
                _estado = CreateObjectSet<Estado>();
                _municipio = CreateObjectSet<Municipio>();
                _colonia = CreateObjectSet<Colonia>();
                _tipoTelefono = CreateObjectSet<TipoTelefono>();

                //Arrendatario
                _arrendatario = CreateObjectSet<Arrendatario>();
                _arrendatarioDireccion = CreateObjectSet<ArrendatarioDireccion>();
                _arrendatarioTelefono = CreateObjectSet<ArrendatarioTelefono>();

                //Cliente
                _cliente = CreateObjectSet<Cliente>();
                _clienteDireccion = CreateObjectSet<ClienteDireccion>();
                _clienteTelefono = CreateObjectSet<ClienteTelefono>();
                _atencionTelefonica = CreateObjectSet<AtencionTelefonica>();

                //Catalogos
                _medioContacto = CreateObjectSet<MedioPublicidad>();
                _tipoPoliza = CreateObjectSet<TipoPoliza>();
                _tipoUso = CreateObjectSet<TipoUso>();
                _tipoinmueble = CreateObjectSet<TipoInmueble>();
                //Sin utilizar
                //_audiencia = CreateObjectSet<Audiencia>();
                //_caso = CreateObjectSet<Caso>();
                _cita = CreateObjectSet<Cita>();

                _pantalla = CreateObjectSet<Pantalla>();
                _puesto = CreateObjectSet<Puesto>();
                _rol = CreateObjectSet<Rol>();
                _rolPantalla = CreateObjectSet<RolPantalla>();

                _usuario = CreateObjectSet<Usuario>();
                _usuarioDireccion = CreateObjectSet<UsuarioDireccion>();
                _usuarioRol = CreateObjectSet<UsuarioRol>();
                _usuarioTelefono = CreateObjectSet<UsuarioTelefono>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
