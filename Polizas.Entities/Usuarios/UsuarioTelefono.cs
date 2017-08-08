using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Usuarios
{
    [DataContract(IsReference = true)]
    public class UsuarioTelefono
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdTipoTelefono { get; set; }
        [DataMember]
        public Int64 IdUsuario { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Extension { get; set; }
        [DataMember]
        public bool Principal { get; set; }

        [DataMember]
        public virtual TipoTelefono TipoTelefono { get; set; }
        [DataMember]
        public virtual Usuario Usuario { get; set; }
    }
}
