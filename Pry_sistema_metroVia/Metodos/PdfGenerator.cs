using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_sistema_metroVia.Metodos
{
    internal class PdfGenerator
    {
        public string GenerarPdf(string content, string outputPath)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));
                document.Open();
                document.Add(new Paragraph(content));
                document.Close();
                return outputPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al generar el PDF: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
