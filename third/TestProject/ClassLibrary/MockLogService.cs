namespace ServiceBox
{
    public class MockLogService : ILogService
    {
        public string? lastError;

        public void LogError(string error)
        {
            lastError = error;
        }
    }
}