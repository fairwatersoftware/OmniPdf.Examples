namespace OmniPdf.Example.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new HtmlToPdf
            {
                LicenseKey = "" // Add license key here
            };

            var document = converter.LoadString("<p>Hello, World!</p>");

            var filename = "omnipdf-example-console.pdf";
            document.SaveFile(filename);

            System.Console.WriteLine("File saved: " + filename);
        }
    }
}
