using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.Production
{
    // concrete RocketProduction realization of Template

    public class RocketProduction : Production
    {
        public override void GetWeaponList()
        {
            Console.WriteLine("Rocket list received");
        }

        public override void ModifyWeaponList()
        {
            Console.WriteLine("Rocket list modified.");
        }

        public override void SaveChanges()
        {
            Console.WriteLine("Rocket list changes saved.");
        }
    }
}
