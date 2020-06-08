using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.Production
{
    public class WeaponProduction : Production
    {
        public override void GetWeaponList()
        {
            Console.WriteLine("Weapons list received");
        }

        public override void ModifyWeaponList()
        {
            Console.WriteLine("Weapons list modified.");
        }

        public override void SaveChanges()
        {
            Console.WriteLine("Weapons list changes saved.");
        }
    }
}
