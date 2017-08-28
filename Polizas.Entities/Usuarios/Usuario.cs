using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Clientes;

namespace Polizas.Entities.Usuarios
{
    [DataContract(IsReference = true)]
    public class Usuario
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdPuesto { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public string NombreUsuario { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        [DataMember]
        public virtual List<Cliente> ClienteAlta { get; set; }
        [DataMember]
        public virtual List<Cliente> ClienteModifico { get; set; }
        [DataMember]
        public virtual List<Cita> Cita { get; set; }
        [DataMember]
        public virtual Puesto Puesto { get; set; }
        [DataMember]
        public virtual List<UsuarioRol> UsuarioRol { get; set; }
        [DataMember]
        public virtual List<UsuarioDireccion> UsuarioDireccion { get; set; }
        [DataMember]
        public virtual List<UsuarioTelefono> UsuarioTelefono { get; set; }
        [DataMember]
        public virtual List<Cliente> ClientesReferenciados { get; set; }
    }
}
