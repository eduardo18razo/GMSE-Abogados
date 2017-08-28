using System;
using System.IO;
using Polizas.Business.Manager;

namespace Polizas.Business.Utils
{
    public static class FileManager
    {
        public static void EliminarDocumentoTemporal(string fileName)
        {
            try
            {
                string pathRoot = BusinessVariables.Directorio.DirectorioAplciacion + BusinessVariables.Directorio.CarpetaTemporales;
                string fullPath = pathRoot + fileName;
                if (File.Exists(fullPath))
                {
                    File.Delete(fullPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
