namespace ServiceBox
{
    public class StubLogService : ILogService
    {
        public void LogError(string error)
        {
            throw new Exception(error);
        }
    }
}