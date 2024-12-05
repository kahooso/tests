namespace ServiceBox
{
    public class StubDataAccess : IDataAccess
    {
        public List<string> getFileNames()
        {
            return new List<string> { "File1.txt", "File2.log", "Short" };
        }
    }
}