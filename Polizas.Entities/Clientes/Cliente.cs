using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Inmueble;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities.Clientes
{
    [DataContract(IsReference = true)]
    public class Cliente
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64? IdUsuarioReferencia { get; set; }
        [DataMember]
        public string NoContrato { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public bool PersonaFisica { get; set; }
        [DataMember]
        public bool ActividadEmpresarial { get; set; }
        [DataMember]
        public string Rfc { get; set; }
        [DataMember]
        public string RepresentanteLegal { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public DateTime? FechaNacimiento { get; set; }
        [DataMember]
        public DateTime FechaAlta { get; set; }
        public virtual Usuario UsuarioReferencia { get; set; }

        [DataMember]
        public virtual List<Cita> Cita { get; set; }
        [DataMember]
        public virtual List<ClienteDireccion> ClienteDireccion { get; set; }
        [DataMember]
        public virtual List<ClienteTelefono> ClienteTelefono { get; set; }
        [DataMember]
        public virtual List<AtencionTelefonica> AtencionTelefonica { get; set; }
        [DataMember]
        public virtual List<InmuebleCliente> InmuebleCliente { get; set; }
    }
}
