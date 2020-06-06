namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public abstract class Report
    {
        public bool State { get; } 
        public Report(bool state)
        {
            State = state;
        }
    }
}