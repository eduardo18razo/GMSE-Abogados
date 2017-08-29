using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Catalogos
{
    [DataContract(IsReference = true)]
    public class TipoPoliza
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        [DataMember]
        public virtual List<AtencionTelefonica> AtencionTelefonica { get; set; }
    }
}
