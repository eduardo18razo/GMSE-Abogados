using System.Collections.Generic;

namespace Polizas.Business.Documentos
{
    public class Marcadores
    {
        public Dictionary<string, string> MarcadoresAutorizacionBuroCredito
        {
            get
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                result.Add("PersonaFisica", string.Empty);
                result.Add("PersonaFisicaActividadEmpresarial", string.Empty);
                result.Add("PersonaMoral", string.Empty);
                result.Add("NombreSolicitante", string.Empty);
                result.Add("RepresentanteLegal", string.Empty);
                result.Add("RFC", string.Empty);
                result.Add("CalleNumero", string.Empty);
                result.Add("Colonia", string.Empty);
                result.Add("Municipio", string.Empty);
                result.Add("Estado", string.Empty);
                result.Add("CP", string.Empty);
                result.Add("Telefonos", string.Empty);
                result.Add("FFA", string.Empty);
                return result;
            }
        }
    }
}
