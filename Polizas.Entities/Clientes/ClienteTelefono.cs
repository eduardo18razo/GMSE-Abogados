using System;
using System.Runtime.Serialization;

namespace Polizas.Entities.Clientes
{
    [DataContract(IsReference = true)]
    public class ClienteTelefono
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdCliente { get; set; }
        [DataMember]
        public Int64 IdTipoTelefono { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Extensiones { get; set; }
        [DataMember]
        public virtual TipoTelefono TipoTelefono { get; set; }
    }
}
