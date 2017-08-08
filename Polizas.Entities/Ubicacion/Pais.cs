using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Ubicacion
{
    [DataContract(IsReference = true)]
    public class Pais
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string RegionCode { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        public virtual List<Estado> Estado { get; set; }
    }
}
