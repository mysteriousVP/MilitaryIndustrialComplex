using MilitaryIndustrialComplexSolution.ReportsManager;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.MediatorNotifing
{
    public class ProductionReceiver : Receiver
    {
        public ProductionReceiver(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            ReportSender emailReportSender = new EmailReportSender($"Message to production: {message}");
            Report report = emailReportSender.CreateReport();
        }
    }
}
