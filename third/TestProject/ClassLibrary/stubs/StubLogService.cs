using ServiceBox.interfaces;

namespace ServiceBox.stubs
{
    public class StubLogService : ILogService
    {
        public void LogError(string message)
        {
            throw new Exception(message);
        }
    }
}