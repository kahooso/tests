namespace ServiceBox
{
    public class StubLogService : ILogService
    {
        public void LogError(string message)
        {
            throw new Exception(message);
        }
    }
}