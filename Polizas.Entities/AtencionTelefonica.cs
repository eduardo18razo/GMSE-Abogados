using System;
using System.Runtime.Serialization;
using Polizas.Entities.Catalogos;
using Polizas.Entities.Clientes;
using Polizas.Entities.Inmueble;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class AtencionTelefonica
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64? IdCliente { get; set; }
        [DataMember]
        public int? IdMedioPublicidad { get; set; }
        [DataMember]
        public int? IdTipoUso { get; set; }
        [DataMember]
        public int? IdTipoPoliza { get; set; }
        [DataMember]
        public int? IdEstatusPagoPoliza { get; set; }
        [DataMember]
        public decimal? RentaCosto { get; set; }
        [DataMember]
        public string Observaciones { get; set; }
        [DataMember]
        public bool? Pagado { get; set; }
        [DataMember]
        public decimal? Vencidas { get; set; }
        [DataMember]
        public int? TotalPagos { get; set; }
        [DataMember]
        public string Nota { get; set; }
        [DataMember]
        public DateTime? FechaHoraContacto { get; set; }

        [DataMember]
        public TipoUso TipoUso { get; set; }

        [DataMember]
        public TipoPoliza TipoPoliza { get; set; }
        [DataMember]
        public MedioPublicidad MedioPublicidad { get; set; }
        [DataMember]
        public EstatusPagoPoliza EstatusPagoPoliza { get; set; }
        [DataMember]
        public Cliente Cliente { get; set; }
    }
}
