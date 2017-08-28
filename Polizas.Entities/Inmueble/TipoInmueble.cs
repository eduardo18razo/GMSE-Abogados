using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Inmueble
{
    public class TipoInmueble
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        [DataMember]
        public virtual InmuebleCliente InmuebleCliente { get; set; }
    }
}
