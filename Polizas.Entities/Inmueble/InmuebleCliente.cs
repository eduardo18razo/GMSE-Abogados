using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Polizas.Entities.Clientes;
using Polizas.Entities.Ubicacion;

namespace Polizas.Entities.Inmueble
{
    public class InmuebleCliente
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdCliente { get; set; }
        [DataMember]
        public Int64 IdTipoInmueble { get; set; }
        [DataMember]
        public int IdTipoUso { get; set; }
        [DataMember]
        public string Calle { get; set; }
        [DataMember]
        public string NoExt { get; set; }
        [DataMember]
        public string NoInt { get; set; }
        [DataMember]
        public int IdColonia { get; set; }
        [DataMember]
        public decimal Renta { get; set; }
        [DataMember]
        public decimal Mantenimiento { get; set; }
        [DataMember]
        public decimal NumeroDepositos { get; set; }
        [DataMember]
        public decimal CantidadDepositos { get; set; }
        [DataMember]
        public bool Habilitado { get; set; }
        
        [DataMember]
        public virtual Cliente Cliente { get; set; }
        [DataMember]
        public virtual TipoInmueble TipoInmueble { get; set; }
        [DataMember]
        public virtual Colonia Colonia { get; set; }
        [DataMember]
        public virtual TipoUso TipoUso { get; set; }
        [DataMember]
        public virtual List<InmuebleArrendado> InmuebleArrendado { get; set; }
    }
}
