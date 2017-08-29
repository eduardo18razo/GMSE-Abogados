using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Polizas.Entities.Helpers
{
    public class HelperInmueble
    {
        public Int64 IdTipoInmueble { get; set; }
        [DataMember]
        public int IdTipoUso { get; set; }
        [DataMember]
        public string Calle { get; set; }
        [DataMember]
        public string NoExt { get; set; }
        [DataMember]
        public string NoInt { get; set; }
        [DataMember]
        public int IdColonia { get; set; }
        [DataMember]
        public decimal Renta { get; set; }
        [DataMember]
        public decimal Mantenimiento { get; set; }
        [DataMember]
        public decimal NumeroDepositos { get; set; }
        [DataMember]
        public decimal CantidadDepositos { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
    }
}
