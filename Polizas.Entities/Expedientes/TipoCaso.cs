using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Expedientes
{
    [DataContract(IsReference = true)]
    public class TipoCaso
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        [DataMember]
        public virtual List<Caso> Caso { get; set; }
    }
}
