using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities.Roles
{
    [DataContract(IsReference = true)]
    public class Rol
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        [DataMember]
        public virtual List<RolPantalla> RolPantalla { get; set; }
        [DataMember]
        public virtual List<UsuarioRol> UsuarioRol { get; set; }
    }
}
