using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OmniPdf.Example.Core.RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        public ActionResult OnPostDownload()
        {
            var converter = new HtmlToPdf();
            var document = converter.LoadString("<p>Hello, World!</p>");
            var stream = document.GetStream();

            return File(stream, "application/pdf", "omnipdf-example-razorpages.pdf");
        }
    }
}
