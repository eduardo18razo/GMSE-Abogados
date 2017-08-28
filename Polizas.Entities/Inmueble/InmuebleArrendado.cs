using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Inmueble
{
    public class InmuebleArrendado
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdInmueble { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public DateTime FechaFin { get; set; }
        [DataMember]
        public bool Vigente { get; set; }

        [DataMember]
        public virtual InmuebleCliente InmuebleCliente { get; set; }
    }
}
