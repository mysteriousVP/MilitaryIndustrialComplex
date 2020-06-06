namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class EmailReport : Report
    {
        public EmailReport()
            :base(true)
        {
            System.Console.WriteLine("Email report created.\n");
        }
    }
}