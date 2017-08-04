using System;
using System.Runtime.Serialization;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Registro
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public bool PersonaFisica { get; set; }
        [DataMember]
        public int? IdUsarioAlta { get; set; }
        [DataMember]
        public DateTime? FechaAlta { get; set; }
        [DataMember]
        public int? IdUsuarioModifico { get; set; }
        [DataMember]
        public DateTime? IdFechaModificacion { get; set; }

        [DataMember]
        public virtual Usuario UsuarioAlta { get; set; }
        [DataMember]
        public virtual Usuario UsuarioModifico { get; set; }
    }
}
