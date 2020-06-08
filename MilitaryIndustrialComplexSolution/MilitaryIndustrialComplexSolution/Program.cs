using MilitaryIndustrialComplexSolution.MediatorNotifing;
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
            ServerMediator mediator = new ServerMediator();
            Receiver production = new ProductionReceiver(mediator);
            Receiver productionStore = new ProductionStoreReceiver(mediator);

            mediator.Production = production;
            mediator.ProductionStore = productionStore;

            productionStore.Send("List of products to be created....");
            production.Send("List of goods sent to the warehouse....");

            Console.ReadLine();
        }
    }
}
