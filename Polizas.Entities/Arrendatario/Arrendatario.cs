using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Polizas.Entities.Arrendatario
{
    [DataContract(IsReference = true)]
    public class Arrendatario
    {

        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdUsuarioReferencia { get; set; }
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
        public virtual List<ArrendatarioDireccion> ArrendatarioDireccion { get; set; }
        [DataMember]
        public virtual List<ArrendatarioTelefono> ArrendatarioTelefono { get; set; }
    }
}
