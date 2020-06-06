using MilitaryIndustrialComplexSolution.ReportMakerFacade;
using MilitaryIndustrialComplexSolution.ReportsManager;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReportManagerTests
{
    public class ReportFacadeTests
    {
        [Fact]
        public void TestSuccesfullyExecutionOfCreatedFacade()
        {
            // arrange 
            string emailData = "Email data";
            string jsonData = "Json data";
            string pdfData = "Pdf data";

            ReportFacade facade = new ReportFacade(new EmailReportSender(emailData),
                new JsonReportSender(jsonData), new PdfReportSender(pdfData));
            ReportClient client = new ReportClient();

            // act
            // assert
            Assert.True(client.CreateReports(facade));
        }

        [Fact]
        public void TestFacadeOnExceptionThrowing()
        {
            // arrange 
            string emailData = "Email data";
            string pdfData = "Pdf data";

            ReportFacade facade = new ReportFacade(new EmailReportSender(emailData),
                null, new PdfReportSender(pdfData));
            ReportClient client = new ReportClient();

            // act
            // assert
            Assert.Throws<NullReferenceException>(() => client.CreateReports(facade));
        }
    }
}
