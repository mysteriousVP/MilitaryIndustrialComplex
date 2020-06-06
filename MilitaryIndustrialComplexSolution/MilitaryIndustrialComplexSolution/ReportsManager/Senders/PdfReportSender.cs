using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class PdfReportSender : ReportSender
    {
        public PdfReportSender(string data)
            : base(data)
        {
            Console.WriteLine("Pdf report sender created.");
        }

        public override Report CreateReport()
        {
            Console.WriteLine("Converting process to pdf format.");
            return new PdfReport();
        }
    }
}
