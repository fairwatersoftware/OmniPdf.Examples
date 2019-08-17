using System.Web.Mvc;

namespace OmniPdf.Example.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public FileResult Download()
        {
            var converter = new HtmlToPdf();
            var document = converter.LoadString("<p>Hello, World!</p>");
            var stream = document.GetStream();
            
            return File(stream, "application/pdf", "omnipdf-example-mvc.pdf");
        }
    }
}
