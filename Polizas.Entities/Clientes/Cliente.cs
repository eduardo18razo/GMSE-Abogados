using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Expedientes;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities.Clientes
{
    [DataContract(IsReference = true)]
    public class Cliente
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public string Expediente { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public bool PersonaFisica { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public Int64 IdUsuarioAlta { get; set; }
        [DataMember]
        public DateTime FechaAlta { get; set; }
        [DataMember]
        public Int64 IdUsuarioModifico { get; set; }
        [DataMember]
        public DateTime IdFechaModificacion { get; set; }

        [DataMember]
        public virtual Usuario UsuarioAlta { get; set; }
        [DataMember]
        public virtual Usuario UsuarioModifico { get; set; }
        [DataMember]
        public virtual List<Cita> Cita { get; set; }
        [DataMember]
        public virtual List<Caso> Caso { get; set; }
        [DataMember]
        public virtual List<ClienteDireccion> ClienteDireccion { get; set; }
        [DataMember]
        public virtual List<ClienteTelefono> ClienteTelefono { get; set; }
    }
}
