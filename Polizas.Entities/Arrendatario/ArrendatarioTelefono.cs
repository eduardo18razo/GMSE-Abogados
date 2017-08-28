using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Arrendatario
{
    [DataContract(IsReference = true)]
    public class ArrendatarioTelefono
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdArrendatario { get; set; }
        [DataMember]
        public Int64 IdTipoTelefono { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Extensiones { get; set; }
        [DataMember]
        public virtual TipoTelefono TipoTelefono { get; set; }
        [DataMember]
        public virtual Arrendatario Arrendatario { get; set; }
    }
}
