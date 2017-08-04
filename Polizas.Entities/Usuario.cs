using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Usuario
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string NombreUsuario { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int IdRol { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        [DataMember]
        public virtual Rol Rol { get; set; }

        [DataMember]
        public virtual List<Registro> RegistroAlta { get; set; }
        [DataMember]
        public virtual List<Registro> RegistroModifico { get; set; }
    }
}
