using MilitaryIndustrialComplexSolution.ReportsManager;
using System;

namespace MilitaryIndustrialComplexSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello there!";
            ReportSender sender = new EmailReportSender(data);
            Report emailReport = sender.CreateReport();

            sender = new JsonReportSender(data);
            Report jsonReport = sender.CreateReport();

            sender = new PdfReportSender(data);
            Report pdfReport = sender.CreateReport();

            Console.ReadLine();
        }
    }
}
