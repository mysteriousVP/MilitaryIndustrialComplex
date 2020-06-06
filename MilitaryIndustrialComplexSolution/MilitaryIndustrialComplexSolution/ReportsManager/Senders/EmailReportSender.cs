using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class EmailReportSender : ReportSender
    {

        public EmailReportSender(string data)
            : base(data)
        {
            Console.WriteLine("Email report sender created.");
        }

        public override Report Send()
        {
            Console.WriteLine("Converting process to email format.");
            return new EmailReport();
        }
    }
}
