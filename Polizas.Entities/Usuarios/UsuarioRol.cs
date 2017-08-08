using System;
using System.Runtime.Serialization;
using Polizas.Entities.Roles;

namespace Polizas.Entities.Usuarios
{
    [DataContract(IsReference = true)]
    public class UsuarioRol
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdUsuario { get; set; }
        [DataMember]
        public Int64 IdRol { get; set; }

        [DataMember]
        public virtual Usuario Usuario { get; set; }
        [DataMember]
        public virtual Rol Rol { get; set; }
    }
}
