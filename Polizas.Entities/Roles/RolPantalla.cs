using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
