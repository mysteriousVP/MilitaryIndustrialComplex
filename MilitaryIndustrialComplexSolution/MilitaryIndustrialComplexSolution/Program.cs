using MilitaryIndustrialComplexSolution.Production;
using MilitaryIndustrialComplexSolution.ReportMakerFacade;
using MilitaryIndustrialComplexSolution.ReportsManager;
using System;

namespace MilitaryIndustrialComplexSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketProduction rocketProduction = new RocketProduction();
            WeaponProduction weaponProduction = new WeaponProduction();

            rocketProduction.ModerateProduction();
            weaponProduction.ModerateProduction();



            //string emailData = "Email data";
            //string jsonData = "Json data";
            //string pdfData = "Pdf data";

            //ReportFacade facade = new ReportFacade(new EmailReportSender(emailData),
            //   null, new PdfReportSender(pdfData));

            //ReportClient client = new ReportClient();
            //client.CreateReports(facade);
            Console.ReadLine();
        }
    }
}
