using System;
using System.Configuration;

namespace Polizas.Business.Manager
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

        public static class FileTemplates
        {
            public static string AutorizacionBuroCredito = "AUTORIZACIÓN CONSULTA BURO DE CRÉDITO.docx";
            public static string AvisoPrivacidad = "AVISO DE PRIVACIDAD.docx";
            public static string ContratoArrendamiento = "CONTRATO DE ARRENDAMIENTO NUEVO MEJORADO.docx";
            public static string ContratoPolizaEsencial = "CONTRATO DE PRESTACIÓN DE SERVICIOS PROFESIONALES ESENCIAL.docx";
            public static string ContratoPolizaTotal = "CONTRATO DE PRESTACIÓN DE SERVICIOS PROFESIONALES TOTAL.docx";
            public static string EtiquetasPoliza = "ETIQUETAS PARA POLIZA.docx";
            public static string AtencionTelefonica = "FORMATO ATENCION TELEFONICA.xlsx";
            public static string Pagares = "PAGARÉS.doc";
            public static string RecibosPago = "RECIBOS DE PAGO.doc";
            public static string PolizaEsencial = "SEGURIDAD EN ARRENDAMIENTO ESENCIAL 1RA VEZ.docx";
            public static string PolizaTotal = "SEGURIDAD EN ARRENDAMIENTO TOTAL 1RA VEZ.docx";

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
