using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security;

namespace Polizas.Entities.Juzgados
{
    [DataContract(IsReference = true)]
    public class Juzgado
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        [DataMember]
        public virtual List<JuzgadoDireccion> JuzgadoDireccion { get; set; }
        [DataMember]
        public virtual List<JuzgadoTelefono> JuzgadoTelefono { get; set; }
        [DataMember]
        public virtual List<Audiencia> Audiencia { get; set; }
    }
}
