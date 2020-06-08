using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.Production
{
    internal abstract class Production
    {
        public Production()
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
            Console.WriteLine("Weapons list change was successful.\n");
        }
    }
}
