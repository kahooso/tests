using ServiceBox.interfaces;

namespace ServiceBox.stubs
{
    public class StubDataAccess : IDataAccess
    {
        public List<string> getFileNames()
        {
            return new List<string> { "File1.tx", "File2.log", "Short" };
        }
    }
}