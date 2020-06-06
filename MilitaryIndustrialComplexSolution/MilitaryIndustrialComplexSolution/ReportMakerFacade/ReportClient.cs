using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportMakerFacade
{
    public class ReportClient
    {
        public void CreateReports(ReportFacade facade)
        {
            try
            {
                facade.MakeAllReports();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            finally
            {
                facade.Stop();
            }
        }
    }
}
