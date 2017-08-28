using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using Novacode;
using Polizas.Entities.Clientes;
using Application = Microsoft.Office.Interop.Word.Application;
using Bookmark = Novacode.Bookmark;

namespace Polizas.Business.Manager
{
    public class DocumentManager
    {

        public List<string> GetMarkers(string file)
        {
            List<string> marcadores = null;
            try
            {
                //using (DocX docX = DocX.Load(string.Format("{0}{1}{2}", BusinessVariables.Directorio.DirectorioAplciacion, BusinessVariables.Directorio.CarpetaPlantillas, BusinessVariables.Files.File1)))
                using (DocX docX = DocX.Load(file))
                {
                    var z = docX.Bookmarks;
                    marcadores = new List<string>();
                    foreach (Bookmark bookmark in docX.Bookmarks)
                    {
                        marcadores.Add(bookmark.Name);
                    }
                    //docX.Bookmarks["Nombre"].SetText(persona.Nombre);
                    //docX.Bookmarks["Fecha"].SetText(persona.Fecha.ToString("dd/MM/yyyy"));
                    //string fileName = string.Format("{0}.docx", persona.Nombre);
                    //string sourceFile = pathSave + fileName;
                    //docX.SaveAs(string.Format(sourceFile));
                    //if (new DropBoxManager().Upload(persona.Nombre, fileName, sourceFile))
                    //{
                    //    EliminarDocumentoTemporal(fileName);
                    //    throw new Exception("Se registro correctamente.");
                    //}

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return marcadores;
        }
        public void GenerateDocx(Cliente persona)
        {
            //try
            //{
            //    string pathSave = BusinessVariables.Directorio.DirectorioAplciacion + BusinessVariables.Directorio.CarpetaTemporales;
            //    using (DocX docX = DocX.Load(string.Format("{0}{1}{2}", BusinessVariables.Directorio.DirectorioAplciacion, BusinessVariables.Directorio.CarpetaPlantillas, BusinessVariables.Files.File1)))
            //    {
            //        docX.Bookmarks["Nombre"].SetText(persona.Nombre);
            //        docX.Bookmarks["Fecha"].SetText(persona.Fecha.ToString("dd/MM/yyyy"));
            //        string fileName = string.Format("{0}.docx", persona.Nombre);
            //        string sourceFile = pathSave + fileName;
            //        docX.SaveAs(string.Format(sourceFile));
            //        if (new DropBoxManager().Upload(persona.Nombre, fileName, sourceFile))
            //        {
            //            EliminarDocumentoTemporal(fileName);
            //            throw new Exception("Se registro correctamente.");
            //        }

            //    }


            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        public void PrintWordDocument(string file)
        {
            Application wordApp = new Application();
            wordApp.Visible = false;
            object nullobj = Missing.Value;
            Document doccument = wordApp.Documents.Open(file,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj,
                ref nullobj, ref nullobj, ref nullobj);

            doccument.Activate();
            int dialogResult = wordApp.Dialogs[WdWordDialog.wdDialogFilePrint].Show(ref nullobj);

            if (dialogResult == 1)
            {
                doccument.PrintOut(ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                             ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                             ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                             ref nullobj, ref nullobj, ref nullobj, ref nullobj,
                             ref nullobj, ref nullobj);
            }
            doccument.Close();
            wordApp.Quit();
            GC.Collect();
        }

        public void PrintFile(string file)
        {
            using (StreamReader printfile = new StreamReader(file))
            {
                try
                {
                    PrintDocument docToPrint = new PrintDocument();
                    docToPrint.DocumentName = "prueba"; //Name that appears in the printer queue
                    //docToPrint.PrintPage += (s,
                    //            ev) =>
                    //        {
                    //            float linesPerPage = 0;
                    //            float yPos = 0;
                    //            int count = 0;
                    //            float leftMargin = ev.MarginBounds.Left;
                    //            float topMargin = ev.MarginBounds.Top;
                    //            string line = null;

                    //            // Calculate the number of lines per page.
                    //            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

                    //            // Print each line of the file. 
                    //            while (count < linesPerPage && ((line = Printfile.ReadLine()) != null))
                    //            {
                    //                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                    //                ev.Graphics.DrawString(line,
                    //                            printFont,
                    //                            Brushes.Black,
                    //                            leftMargin,
                    //                            yPos,
                    //                            new StringFormat());
                    //                count++;
                    //            }

                    //            // If more lines exist, print another page. 
                    //            if (line != null)
                    //                ev.HasMorePages = true;
                    //            else
                    //                ev.HasMorePages = false;
                    //        }
                    //        ;
                    docToPrint.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        
    }
}
