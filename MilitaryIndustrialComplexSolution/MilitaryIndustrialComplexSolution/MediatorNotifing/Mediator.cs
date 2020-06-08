using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution
{
    public abstract class Mediator
    {
        public abstract bool SendEmail(string msg, Receiver receiver);
    }
}
