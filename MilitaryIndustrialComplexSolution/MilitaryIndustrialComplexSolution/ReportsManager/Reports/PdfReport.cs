namespace MilitaryIndustrialComplexSolution.ReportsManager
{
    public class PdfReport : Report
    {
        
        public PdfReport()
            : base(true)
        {
            System.Console.WriteLine("Pdf report created.\n");
        }
    }
}