using MilitaryIndustrialComplexSolution.Production;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReportManagerTests
{
    public class TemplateTests
    {
        [Fact]
        public void TemplateRocketProductionWork()
        {
            // arrange
            RocketProduction rocketProduction = new RocketProduction();

            // act
            // assert
            rocketProduction.ModerateProduction();
        }

        [Fact]
        public void TemplateWeaponProductionWork()
        {
            // arrange
            WeaponProduction weaponProduction = new WeaponProduction();

            // act
            // assert
            weaponProduction.ModerateProduction();
        }
    }
}
