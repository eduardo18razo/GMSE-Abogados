using System;
using System.Configuration;

namespace Polizas.Business
{
    public static class BusinessVariables
    {
        public static class Dropbox
        {
            public static string Token = ConfigurationManager.AppSettings["Token"];
        }
        public static class Directorio
        {
            public static string DirectorioAplciacion = AppDomain.CurrentDomain.BaseDirectory;
            public static string CarpetaPlantillas = ConfigurationManager.AppSettings["FolderTemplate"];
            public static string CarpetaPrincipalDropBox = "/" + ConfigurationManager.AppSettings["FolderDropBox"];
            public static string CarpetaTemporales = ConfigurationManager.AppSettings["FolderTemporales"];
        }
        public static class Files
        {
            public static string File1 = ConfigurationManager.AppSettings["File1"];
        }

        public static class ComboBoxCatalogo
        {
            public static int IndexSeleccione = 0;
            public static int IndexTodos = 1;
            public static int ValueSeleccione = 0;
            public static int ValueTodos = -1;
            public static string DescripcionSeleccione = "==SELECCIONE==";
            public static string DescripcionTodos = "==TODOS==";
            public static bool Habilitado = false;
        }
    }
}
