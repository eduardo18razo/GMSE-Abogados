using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Rol
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
         [DataMember]
        public virtual List<Usuario> Usuario { get; set; }
    }
}
