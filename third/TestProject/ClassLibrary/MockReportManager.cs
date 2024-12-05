namespace ServiceBox
{
    public class MockReportManager : IReportManager
    {
        public List<string>? savedReportData;

        public void saveReport(List<String> reportData)
        {
            savedReportData = reportData;
        }
    }
}