﻿using System;
using System.Runtime.Serialization;
using Polizas.Entities.Clientes;
using Polizas.Entities.Usuarios;

namespace Polizas.Entities
{
    [DataContract(IsReference = true)]
    public class Cita
    {
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public Int64 IdUsuario { get; set; }
        [DataMember]
        public Int64 IdCliente { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public string BorderColor { get; set; }
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public virtual Usuario Usuario { get; set; }
        [DataMember]
        public virtual Cliente Cliente { get; set; }
    }
}
