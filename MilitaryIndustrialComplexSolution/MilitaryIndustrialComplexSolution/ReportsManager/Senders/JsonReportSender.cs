using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class JsonReportSender : ReportSender
    {

        public JsonReportSender(string data)
            : base(data)
        {
            Console.WriteLine("Json report sender created.");
        }

        public override Report Send()
        {
            Console.WriteLine("Converting process to json format.");
            return new JsonReport();
        }
    }
}
