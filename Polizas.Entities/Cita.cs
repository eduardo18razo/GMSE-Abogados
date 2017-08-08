using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Cita
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public int IdRegistro { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public string BorderColor { get; set; }
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public virtual Usuario Usuario { get; set; }
        [DataMember]
        public virtual Registro Registro { get; set; }
    }
}
