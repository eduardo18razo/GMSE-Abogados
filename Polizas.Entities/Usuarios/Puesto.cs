using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Usuarios
{
    public class Puesto
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        [DataMember]
        public virtual List<Usuario> Usuario { get; set; }
    }
}