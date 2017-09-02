using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Polizas.Entities.Helpers
{
    public class HelperInmueble
    {
        [DataMember]
        public Int64 IdTipoInmueble { get; set; }
        [DataMember]
        [DisplayName("Tipo de inmueble")]
        public string TipoInmueble { get; set; }
        [DataMember]
        public int IdTipoUso { get; set; }
        [DataMember]
        [DisplayName("Uso de suelo")]
        public string UsoSuelo { get; set; }
        [DataMember]
        public string Calle { get; set; }
        [DataMember]
        public string NoExt { get; set; }
        [DataMember]
        public string NoInt { get; set; }
        [DataMember]
        public int IdColonia { get; set; }
        [DataMember]
        [DisplayName("Colonia")]
        public string Colonia { get; set; }
        [DataMember]
        [DisplayName("Delegacion o Municipio")]
        public string Municipio { get; set; }
        [DataMember]
        [DisplayName("Estado")]
        public string Estado { get; set; }
        [DataMember]
        public decimal Renta { get; set; }
        [DataMember]
        public decimal Mantenimiento { get; set; }
        [DataMember]
        [DisplayName("Depositos Requeridos")]
        public decimal NumeroDepositos { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
    }
}
