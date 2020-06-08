using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.MediatorNotifing
{
    public class ServerMediator : Mediator
    {
        public Receiver Production { get; set; }
        public Receiver ProductionStore { get; set; }

        public override bool SendEmail(string msg, Receiver receiver)
        {
            if (Production == receiver)
            {
                ProductionStore.Notify(msg);
                return true;
            }

            if (ProductionStore == receiver)
            {
                Production.Notify(msg);
                return true;
            }

            return false;
        }
    }
}
