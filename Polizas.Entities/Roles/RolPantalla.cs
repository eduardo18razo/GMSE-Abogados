using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Roles
{
    [DataContract(IsReference = true)]
    public class RolPantalla
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdRol { get; set; }
        [DataMember]
        public Int64 IdPantalla { get; set; }
        [DataMember]
        public virtual Rol Rol { get; set; }
        [DataMember]
        public virtual Pantalla Pantalla { get; set; }
    }
}
