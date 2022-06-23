using Core_file_migration.Data;
using Core_file_migration.inter;
using Core_file_migration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Core_file_migration.Models.allmodel;
using System.Net.Mail;
using Rotativa.AspNetCore;
using System.Reflection.Metadata;
using iTextSharp.text;
using Document = iTextSharp.text.Document;
using iTextSharp.text.pdf;

namespace Core_file_migration.Controllers
{
    public class ProductController : Controller
    {

        private ApplicationDbContext _context;
        private readonly IHostingEnvironment envio;
        private readonly IRrepository<Product> _unit;

        public ProductController(ApplicationDbContext context, IRrepository<Product> pro, IHostingEnvironment envio)
        {
            _context = context;
            _unit = pro;
            this.envio = envio; 

        }
        public IActionResult Index()
        {
            List<Product> products = _unit.GetAll();
            return View(products);
        }
        /*
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel p)
        {
            if (ModelState.IsValid)
            {
                var fullpath = Path.Combine(envio.ContentRootPath, @"wwwroot\Content\", p.ProductName.FileName);

                FileStream stream = new FileStream(fullpath, FileMode.Create);
                p.ProductName.CopyTo(stream);

                var data = new Product()
                {
                    Name = p.Name,
                    quantity = p.quantity,
                    ProductName = p.ProductName.FileName
                };
                _context.Add(data);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(p);
            }
        }
        */
        /*
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel pp)
        {
            if (ModelState.IsValid)
            {
                foreach (IFormFile p in pp.ProductName)
                {
                    var fullpath = Path.Combine(envio.ContentRootPath, @"wwwroot\Content\", p.FileName);

                    FileStream stream = new FileStream(fullpath, FileMode.Create);
                    p.CopyTo(stream);

                    var data = new Product()
                    {
                        Name = pp.Name,
                        quantity = pp.quantity,
                        ProductName = p.FileName
                    };
                    _context.Add(data);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(pp);
            }
        }
        */

        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel pp)
        {
            if (ModelState.IsValid)
            {
                foreach (IFormFile p in pp.ProductName)
                {
                    var fullpath = Path.Combine(envio.ContentRootPath, @"wwwroot\Content\", p.FileName);

                    FileStream stream = new FileStream(fullpath, FileMode.Create);
                    p.CopyTo(stream);

                    var data = new Product()
                    {
                        Name = pp.Name,
                        quantity = pp.quantity,
                        ProductName = p.FileName
                    };
                    _context.Add(data);
                    _context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            else
            {
                return View(pp);
            }
        }
       string MailBody="Wlcomwe to the questain";
        
        string mailtitle = "Givr change";
        string mailSubject = "Email with the";
        string fromEmail = "bd34017053@gmail.com";
        string password = "qiovdgghfkejmipa";

        public IActionResult EmCreat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmCreat(string toEmail,IFormFile filetoAttach)
        {
            MailMessage message = new MailMessage(new MailAddress(fromEmail, mailtitle),new MailAddress(toEmail));

            message.Subject = mailSubject;
            message.Body = MailBody;
            message.IsBodyHtml = true;

            message.Attachments.Add(new Attachment(filetoAttach.OpenReadStream(), filetoAttach.FileName));

            SmtpClient smtp=new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            System.Net.NetworkCredential credential=new System.Net.NetworkCredential();
            credential.UserName = fromEmail;
            credential.Password = password;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = credential;
            smtp.Send(message);

            return View();
        }

       

        [HttpPost]    
        public IActionResult Genpdf()
        {
            using (MemoryStream ms =new MemoryStream())
            {
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, ms);
                document.Open();

                var image = iTextSharp.text.Image.GetInstance("wwwroot/Content/a.jpg");
                image.Alignment = Element.ALIGN_CENTER;
                document.Add(image);
                Paragraph paral = new Paragraph("This is the first pargraph", new Font(Font.FontFamily.HELVETICA, 20));
                paral.Alignment = Element.ALIGN_CENTER;
                document.Add(paral);

                PdfPTable table = new PdfPTable(2);
                PdfPCell cell = new PdfPCell(new Phrase("Id", new Font(Font.FontFamily.HELVETICA,10)));
                PdfPCell cell1 = new PdfPCell(new Phrase("Name", new Font(Font.FontFamily.HELVETICA, 10)));

                table.AddCell(cell);
                table.AddCell(cell1);

                List<Product>l= _unit.GetAll();


                for (int i = 0; i < l.Count; i++)
                {
                    PdfPCell cel1 = new PdfPCell(new Phrase(l[i].Id));
                    PdfPCell cel2 = new PdfPCell(new Phrase(l[i].Name.ToString()));


                    cel1.HorizontalAlignment= Element.ALIGN_CENTER;
                    cel2.HorizontalAlignment = Element.ALIGN_CENTER;
                    

                    table.AddCell(cel1);
                    table.AddCell(cel2);
                    



                }
                
                document.Add(table);
                document.Close();
                writer.Close();

                var constant = ms.ToArray();

                return File(constant, "application/vnd", "First.pdf");
            }
            return View();
        }
    }
}
