﻿using System;
using System.Runtime.Serialization;
using Polizas.Entities.Ubicacion;

namespace Polizas.Entities.Juzgados
{
    [DataContract(IsReference = true)]
    public class JuzgadoDireccion
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdJuzgado { get; set; }
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
        public virtual Juzgado Juzgado { get; set; }
    }
}
