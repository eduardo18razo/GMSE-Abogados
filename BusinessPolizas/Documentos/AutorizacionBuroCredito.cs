using System;
using System.Linq;
using Novacode;
using Polizas.Business.Manager;
using Polizas.Business.Operacion;
using Polizas.Business.Utils;
using Polizas.Entities.Clientes;

namespace Polizas.Business.Documentos
{
    public class AutorizacionBuroCredito
    {
        public bool GeneraDocumento(int idCliente, DateTime fechaFirma)
        {
            try
            {
                string pathSave = BusinessVariables.Directorio.DirectorioAplciacion + BusinessVariables.Directorio.CarpetaTemporales;
                using (DocX docX = DocX.Load(string.Format("{0}{1}{2}", BusinessVariables.Directorio.DirectorioAplciacion, BusinessVariables.Directorio.CarpetaPlantillas, BusinessVariables.FileTemplates.AutorizacionBuroCredito)))
                {
                    Cliente cte = new BusinessCliente().ObtenerCliente(idCliente);
                    if (cte != null)
                    {
                        docX.Bookmarks["PersonaFisica"].SetText(cte.PersonaFisica ? "X" : string.Empty);
                        docX.Bookmarks["PersonaFisicaActividadEmpresarial"].SetText(cte.ActividadEmpresarial ? "X" : string.Empty);
                        docX.Bookmarks["PersonaMoral"].SetText(!cte.PersonaFisica ? "X" : string.Empty);
                        docX.Bookmarks["NombreSolicitante"].SetText(cte.Nombre.Trim().ToUpper());
                        docX.Bookmarks["RepresentanteLegal"].SetText(cte.RepresentanteLegal.Trim().ToUpper());
                        docX.Bookmarks["RFC"].SetText(cte.Rfc.Trim().ToUpper());
                        if (cte.ClienteDireccion.Count > 0)
                        {
                            ClienteDireccion direccion = cte.ClienteDireccion.First();
                            docX.Bookmarks["CalleNumero"].SetText(string.Format("{0} No. Ext{1} {2}", direccion.Calle.Trim().ToUpper(), direccion.NoExt.Trim().ToUpper(), direccion.NoInt.Trim() == string.Empty ? string.Empty : "No Int " + direccion.NoInt.Trim().ToUpper()));
                            docX.Bookmarks["Colonia"].SetText(direccion.Colonia.Descripcion.Trim().ToUpper());
                            docX.Bookmarks["Municipio"].SetText(direccion.Colonia.Municipio.Descripcion.Trim().ToUpper());
                            docX.Bookmarks["Estado"].SetText(direccion.Colonia.Municipio.Estado.Descripcion.Trim().ToUpper());
                            docX.Bookmarks["CP"].SetText(direccion.Colonia.CP.ToString().Trim().ToUpper().PadLeft(5, '0'));
                        }
                        string telefonos = cte.ClienteTelefono.Aggregate(string.Empty,(current, telefono) => current + (telefono.Extensiones.Trim() == string.Empty
                                    ? telefono.Telefono
                                    : string.Format("{0} {1}", telefono.Telefono, telefono.Extensiones == string.Empty ? string.Empty : "Ext. " + telefono.Extensiones)));
                        docX.Bookmarks["Telefonos"].SetText(telefonos);
                        docX.Bookmarks["FFA"].SetText(fechaFirma.ToShortDateString());
                        docX.Bookmarks["NombreFirma"].SetText(cte.Nombre.Trim().ToUpper());
                        string fileName = string.Format("Autorizacion Buro Credito {0}.docx", cte.Nombre.Trim().ToUpper());
                        string sourceFile = pathSave + fileName;
                        docX.SaveAs(string.Format(sourceFile));
                        if (new DropBoxManager().Upload(cte.Nombre, fileName, sourceFile))
                        {
                            FileManager.EliminarDocumentoTemporal(fileName);
                            throw new Exception("Se registro correctamente.");
                        }
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
