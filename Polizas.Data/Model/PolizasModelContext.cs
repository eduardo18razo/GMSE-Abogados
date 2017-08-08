﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución: 12.0.0.0
//  
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using Polizas.Entities;

namespace Polizas.Data.Model
{
    public class PolizasModelContextBase : ObjectContext
    {
        private readonly EntityConnection _connection;
        private readonly string _connectionString;
        private const string ConnectionString = "name=PolizasEntities";
        private const string ContainerName = "PolizasEntities";

        public PolizasModelContextBase()
            : base(ConnectionString, ContainerName)
        {
            try
            {
                _registros = CreateObjectSet<Registro>();
                _roles = CreateObjectSet<Rol>();
                _usuarios = CreateObjectSet<Usuario>();
                _cita = CreateObjectSet<Cita>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        public PolizasModelContextBase(string connectionString)
            : base(ConnectionString, ContainerName)
        {
            _connectionString = connectionString;
        }

        public PolizasModelContextBase(EntityConnection connection)
            : base(ConnectionString, ContainerName)
        {
            _connection = connection;
        }

        private readonly ObjectSet<Registro> _registros;
        private readonly ObjectSet<Rol> _roles;
        private readonly ObjectSet<Usuario> _usuarios;
        private readonly ObjectSet<Cita> _cita;
        public ObjectSet<Registro> Registros
        {
            get
            {
                return _registros;
            }
        }
        public ObjectSet<Rol> Rol
        {
            get
            {
                return _roles;
            }
        }
        public ObjectSet<Usuario> Usuario
        {
            get
            {
                return _usuarios;
            }
        }

        public ObjectSet<Cita> Cita
        {
            get
            {
                return _cita;
            }
        }
    }
}