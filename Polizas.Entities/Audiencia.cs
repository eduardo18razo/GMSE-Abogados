using System;
using System.Runtime.Serialization;
using Polizas.Entities.Juzgados;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Audiencia
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdUsuarioAsignado { get; set; }
        [DataMember]
        public Int64 IdJuzgado { get; set; }
        [DataMember]
        public DateTime FechaAudiencia { get; set; }
        [DataMember]
        public TimeSpan HoraAudiencia { get; set; }
        [DataMember]
        public String Observaciones { get; set; }
        [DataMember]
        public virtual Juzgado Juzgado { get; set; }
        [DataMember]
        public virtual Usuario Usuario { get; set; }
    }
}
