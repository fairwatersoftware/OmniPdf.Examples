using System;

namespace OmniPdf.Example.WebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void ButtonDownload_Click(object sender, EventArgs e)
        {
            var converter = new HtmlToPdf();
            var document = converter.LoadString("<p>Hello, World!</p>");

            using (var stream = document.GetStream())
            {
                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", string.Format("attachment; filename=omnipdf-example-webforms.pdf"));
                stream.CopyTo(Response.OutputStream);
                Response.End();
            }
        }
    }
}