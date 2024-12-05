using ServiceBox.interfaces;

namespace ServiceBox.mocks
{
    public class MockReportManager : IReportManager
    {
        public List<string>? reportData = new List<string>();

        public void saveReport(List<string> reportData)
        {
            this.reportData = reportData;
        }
    }
}