using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.Entities.Juzgados
{
    [DataContract(IsReference = true)]
    public class JuzgadoTelefono
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdJuzgado { get; set; }
        [DataMember]
        public Int64 IdTipoTelefono { get; set; }
        [DataMember]
        public Int64 IdAreaJuzgado { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Extensiones { get; set; }
        [DataMember]
        public virtual TipoTelefono TipoTelefono { get; set; }
        [DataMember]
        public virtual Juzgado Juzgado { get; set; }
    }
}
