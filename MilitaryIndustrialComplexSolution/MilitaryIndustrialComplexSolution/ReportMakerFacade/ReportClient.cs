using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplexSolution.ReportMakerFacade
{
    public class ReportClient
    {
        public bool CreateReports(ReportFacade facade)
        {
            bool state;
            try
            {
                facade.MakeAllReports();
                state = true;
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException($"Exception message: {ex.Message}");
            }
            finally
            {
                facade.Stop();
            }
            return state;
        }
    }
}
