namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class JsonReport : Report
    {
        public JsonReport()
            :base(true)
        {
            System.Console.WriteLine("Json report created.\n");
        }
    }
}