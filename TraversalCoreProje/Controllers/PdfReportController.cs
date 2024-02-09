using DataAccessLayer.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);
            document.Open();
            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");  
            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir SoyAdı");
            pdfPTable.AddCell("Misafir Tc");


            pdfPTable.AddCell("Adem");
            pdfPTable.AddCell("Yıldırım");
            pdfPTable.AddCell("132827323");

            pdfPTable.AddCell("Atilla");
            pdfPTable.AddCell("Kalay");
            pdfPTable.AddCell("6871916393");

            pdfPTable.AddCell("Ömer");
            pdfPTable.AddCell("Levent");
            pdfPTable.AddCell("993284623");
            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
        public IActionResult DinamikCustomerReport()
        {
            Context _context = new Context();
            var users = _context.Users.ToList();

            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "DinamikMusteriRaporu.pdf");
            var stream = new FileStream(path, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);
            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir SoyAdı");
            pdfPTable.AddCell("Misafir Kullanıcı Adı");
           
            foreach (var user in users)
            {
                pdfPTable.AddCell(user.Name);
                pdfPTable.AddCell(user.SurName);
                pdfPTable.AddCell(user.UserName);
            }

            document.Add(pdfPTable);
            document.Close();

            return File("/pdfreports/DinamikMusteriRaporu.pdf", "application/pdf", "DinamikMusteriRaporu.pdf");
        }
    }
}
