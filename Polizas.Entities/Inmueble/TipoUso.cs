using System.Collections.Generic;

namespace Polizas.Entities.Inmueble
{
    public class TipoUso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Habilitado { get; set; }
        public virtual List<InmuebleCliente> InmuebleCliente { get; set; }
    }
}
