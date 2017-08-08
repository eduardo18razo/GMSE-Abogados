using System;
using System.Runtime.Serialization;
using Polizas.Entities.Ubicacion;

namespace Polizas.Entities.Clientes
{
    [DataContract(IsReference = true)]
    public class ClienteDireccion
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdCliente { get; set; }
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
        public virtual Cliente Cliente { get; set; }
    }
}
