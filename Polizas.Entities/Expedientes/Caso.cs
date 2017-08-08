using System;
using System.Runtime.Serialization;
using Polizas.Entities.Clientes;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities.Expedientes
{
    [DataContract(IsReference = true)]
    public class Caso
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdTipoCaso { get; set; }
        [DataMember]
        public Int64 IdUsuarioAsignado { get; set; }
        [DataMember]
        public Int64 IdCliente { get; set; }
        [DataMember]
        public Int64 IdEstatus { get; set; }
        [DataMember]
        public DateTime FechaInicio { get; set; }
        [DataMember]
        public virtual TipoCaso TipoCaso { get; set; }
        [DataMember]
        public virtual Usuario Usuario { get; set; }
        [DataMember]
        public virtual Cliente Cliente { get; set; }
    }
}
