using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    // report abstract class 
    public abstract class ReportSender
    {
        public string SendData { get; set; }

        public ReportSender(string data)
        {
            SendData = data;
        }

        // fabric method 
        abstract public Report CreateReport();
    }
}
