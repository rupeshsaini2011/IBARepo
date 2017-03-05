using IBAEntities;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBA_BL
{
    public static class PDFExporter
    {

        public static string HandleAContent(AEntity aa)
        {
            string content = String.Empty;

            string path = Utils.GetFileServerPath("a.html");
            if (File.Exists(path))
            {
                try
                {
                    content = File.ReadAllText(path);
                    content = content.Replace("\r\n", String.Empty);

                    content= content.Replace("[[Name]]", aa.Name);


                }
                catch (Exception ex)
                {
                    throw ex;

                }
            }

            return content;

        }

        public static void GeneratePDF()
        {
            Document doc = new Document();
            DateTime d = DateTime.Now;
            string fileName = "A" + d.Day + d.Month + d.Year + d.Hour + d.Minute + ".pdf";
            string filePath = Utils.GetFileServerPath(fileName);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            AEntity aa = new AEntity();
            aa.Name = "Some Name";

            string content = HandleAContent(aa);
            StringReader sr = new StringReader(content);

            HTMLWorker htmlparser = new HTMLWorker(doc);
            htmlparser.Parse(sr);
            //resp.Write(doc);
            doc.Close();

        }

    }
}
