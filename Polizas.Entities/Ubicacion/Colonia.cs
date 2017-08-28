using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Arrendatario;
using Polizas.Entities.Clientes;
using Polizas.Entities.Inmueble;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities.Ubicacion
{
    [DataContract(IsReference = true)]
    public class Colonia
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int? IdMunicipio { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public int CP { get; set; }

        [DataMember]
        public virtual Municipio Municipio { get; set; }
        [DataMember]
        public virtual List<ClienteDireccion> ClienteDireccion { get; set; }
        [DataMember]
        public virtual List<UsuarioDireccion> UsuarioDireccion { get; set; }

        [DataMember]
        public virtual List<ArrendatarioDireccion> ArrendatarioDireccion { get; set; }
        [DataMember]
        public virtual List<InmuebleCliente> InmuebleCliente { get; set; }


    }
}
