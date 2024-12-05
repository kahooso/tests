namespace ServiceBox
{
    public class MockReportManager : IReportManager
    {
        public IEnumerable<string>? savedFileNames { get; set; }

        public void saveReport(IEnumerable<string> fileNames)
        {
            savedFileNames = fileNames;
        }
    }
}