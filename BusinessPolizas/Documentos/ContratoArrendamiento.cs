using System;
using System.Linq;
using Novacode;
using Polizas.Business.Manager;
using Polizas.Business.Utils;
using Polizas.Entities.Clientes;

namespace Polizas.Business.Documentos
{
    public class ContratoArrendamiento
    {
        public bool GeneraDocumento(int idCliente, int idInmueble)
        {
            try
            {
                string pathSave = BusinessVariables.Directorio.DirectorioAplciacion + BusinessVariables.Directorio.CarpetaTemporales;
                using (DocX docX = DocX.Load(string.Format("{0}{1}{2}", BusinessVariables.Directorio.DirectorioAplciacion, BusinessVariables.Directorio.CarpetaPlantillas, BusinessVariables.FileTemplates.ContratoArrendamiento)))
                {
                    Cliente cte = new Cliente();
                    docX.Bookmarks["NombreArrendador"].SetText(cte.PersonaFisica ? "X" : string.Empty);
                    docX.Bookmarks["NombreArrendatario"].SetText(cte.ActividadEmpresarial ? "X" : string.Empty);
                    docX.Bookmarks["FechaArrendamiento"].SetText(!cte.PersonaFisica ? "X" : string.Empty);
                    docX.Bookmarks["TipoInmueble"].SetText(cte.Nombre);
                    docX.Bookmarks["Direccion"].SetText(!cte.PersonaFisica ? cte.RepresentanteLegal : string.Empty);
                    docX.Bookmarks["RFC"].SetText(cte.Rfc);
                    if (cte.ClienteDireccion.Count > 0)
                    {
                        ClienteDireccion direccion = cte.ClienteDireccion.First();
                        docX.Bookmarks["CalleNumero"].SetText(string.Format("{0} No. Ext{1} No Int{2}", direccion.Calle, direccion.NoExt, direccion.NoInt));
                        docX.Bookmarks["Colonia"].SetText(direccion.Colonia.Descripcion);
                        docX.Bookmarks["Municipio"].SetText(direccion.Colonia.Municipio.Descripcion);
                        docX.Bookmarks["Estado"].SetText(direccion.Colonia.Municipio.Estado.Descripcion);
                        docX.Bookmarks["CP"].SetText(direccion.Colonia.CP.ToString().PadLeft(5, '0'));
                    }
                    string telefonos = cte.ClienteTelefono.Aggregate(string.Empty, (current, telefono) => current + (telefono.Extensiones.Trim() == string.Empty ? telefono.Telefono : string.Format("{0} Ext. {1}", telefono.Telefono, telefono.Extensiones)));
                    docX.Bookmarks["Telefonos"].SetText(telefonos);
                    // TODO: Que fecha se aplica aqui o se llena a mano
                    docX.Bookmarks["FFA"].SetText(string.Empty);
                    string fileName = string.Format("Autorizacion Buro Credito {0}.docx", cte.Nombre);
                    string sourceFile = pathSave + fileName;
                    docX.SaveAs(string.Format(sourceFile));
                    if (new DropBoxManager().Upload(cte.Nombre, fileName, sourceFile))
                    {
                        FileManager.EliminarDocumentoTemporal(fileName);
                        throw new Exception("Se registro correctamente.");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }
    }
}
