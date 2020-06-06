using MilitaryIndustrialComplexSolution.ReportsManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportMakerFacade
{
    public class ReportFacade
    {
        ReportSender emailSender;
        ReportSender jsonSender;
        ReportSender pdfSender;
        int reportingState;

        public ReportFacade(EmailReportSender emailSender, JsonReportSender jsonSender, PdfReportSender pdfSender)
        {
            this.emailSender = emailSender;
            this.jsonSender = jsonSender;
            this.pdfSender = pdfSender;
        }

        public ReportFacade(EmailReportSender emailSender, JsonReportSender jsonSender)
        {
            this.emailSender = emailSender;
            this.jsonSender = jsonSender;
        }

        public void MakeAllReports()
        {
            if (emailSender == null || jsonSender == null || pdfSender == null)
                throw new NullReferenceException("Someone of senders are null.");

            Report reportEmail = emailSender.CreateReport();
            Console.WriteLine($"Report email state: {reportEmail.State}");
            Report reportJson = jsonSender.CreateReport();
            Console.WriteLine($"Report json state: {reportJson.State}");
            Report reportPdf = pdfSender.CreateReport();
            Console.WriteLine($"Report Pdf state: {reportPdf.State}");

            reportingState = CheckStatus(reportEmail.State, reportJson.State, reportPdf.State);
        }

        private int CheckStatus(bool first, bool second, bool third)
        {
            if (!first) return 1;
            if (!second) return 2;
            if (!third) return 3;
            return 0;
        }

        public void Stop()
        {
            if (reportingState == 0)
                Console.WriteLine("All reports succesfully created");
            else
                Console.WriteLine($"Not all reports succesfully created. Error token: {reportingState}");
        }
    }
}
