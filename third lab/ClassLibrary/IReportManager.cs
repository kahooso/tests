namespace ServiceBox
{
    public interface IReportManager
    {
        void saveReport(IEnumerable<string> fileNames);
    }
}