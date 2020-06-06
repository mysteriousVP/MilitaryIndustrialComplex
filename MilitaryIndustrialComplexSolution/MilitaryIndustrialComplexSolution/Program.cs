using MilitaryIndustrialComplexSolution.ReportMakerFacade;
using MilitaryIndustrialComplexSolution.ReportsManager;
using System;

namespace MilitaryIndustrialComplexSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailData = "Email data";
            string jsonData = "Json data";
            string pdfData = "Pdf data";

            ReportFacade facade = new ReportFacade(new EmailReportSender(emailData),
                new JsonReportSender(jsonData), new PdfReportSender(pdfData));

            ReportClient client = new ReportClient();
            client.CreateReports(facade);
            Console.ReadLine();
        }
    }
}
