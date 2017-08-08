using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Clientes;
using Polizas.Entities.Juzgados;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class TipoTelefono
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public bool Extension { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }

        [DataMember]
        public virtual List<ClienteTelefono> ClienteTelefono { get; set; }
        [DataMember]
        public virtual List<UsuarioTelefono> UsuarioTelefono { get; set; }
        [DataMember]
        public virtual List<JuzgadoTelefono> JuzgadoTelefono { get; set; }

    }
}
