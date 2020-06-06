using MilitaryIndustrialComplexSolution.ReportsManager;
using System;
using Xunit;

namespace ReportManagerTests
{
    public class ReportSenderTests
    {
        [Fact]
        public void TestEmailReportSender()
        {
            // arrange 
            string data = "Hello there!";
            ReportSender sender = new EmailReportSender(data);

            // act
            Report emailReport = sender.CreateReport();

            // assert
            Assert.True(emailReport.State);
        }

        [Fact]
        public void TestJsonReportSender()
        {
            // arrange 
            string data = "Hello there!";
            ReportSender sender = new JsonReportSender(data);

            // act
            Report jsonReport = sender.CreateReport();

            // assert
            Assert.True(jsonReport.State);
        }

        [Fact]
        public void TestPdflReportSender()
        {
            // arrange 
            string data = "Hello there!";
            ReportSender sender = new PdfReportSender(data);

            // act
            Report pdfReport = sender.CreateReport();

            // assert
            Assert.True(pdfReport.State);
        }
    }
}
