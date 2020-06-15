using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.Production
{
    // abstaract Template class
    public abstract class Production
    {
        public void ModerateProduction()
        {
            GetWeaponList();
            ModifyWeaponList();
            SaveChanges();
            MakeLog();
        }

        public abstract void GetWeaponList();
        public abstract void ModifyWeaponList();
        public abstract void SaveChanges();
        public virtual void MakeLog()
        {
            Console.WriteLine("List change was successful.\n");
        }
    }
}
