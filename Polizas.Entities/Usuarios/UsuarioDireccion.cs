using System;
using System.Runtime.Serialization;
using Polizas.Entities.Ubicacion;

namespace Polizas.Entities.Usuarios
{
    [DataContract(IsReference = true)]
    public class UsuarioDireccion
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdUsuario { get; set; }
        [DataMember]
        public int IdColonia { get; set; }
        [DataMember]
        public string Calle { get; set; }
        [DataMember]
        public string NoExt { get; set; }
        [DataMember]
        public string NoInt { get; set; }
        [DataMember]
        public virtual Colonia Colonia { get; set; }
        [DataMember]
        public virtual Usuario Usuario { get; set; }
    }
}
