using MilitaryIndustrialComplexSolution;
using MilitaryIndustrialComplexSolution.MediatorNotifing;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReportManagerTests
{
    public class MediatorTests
    {
        [Fact]
        public void MediatorProductionNotifing()
        {
            // arrange 
            ServerMediator mediator = new ServerMediator();
            Receiver production = new ProductionReceiver(mediator);
            mediator.Production = production;

            // act
            // assert
            Assert.True(production.Send("List of goods sent to the warehouse...."));
        }

        [Fact]
        public void MediatorProductionStoreNotifing()
        {
            // arrange 
            ServerMediator mediator = new ServerMediator();
            Receiver productionStore = new ProductionStoreReceiver(mediator);
            mediator.ProductionStore = productionStore;

            // act
            // assert
            Assert.True(productionStore.Send("List of products to be created...."));
        }
    }
}
