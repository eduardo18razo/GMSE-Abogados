using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Roles
{
    [DataContract(IsReference = true)]
    public class Pantalla
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public Int64? IdPadre { get; set; }
        public bool? EsMenu { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        [DataMember]
        public virtual List<RolPantalla> RolPantalla { get; set; }
    }
}
