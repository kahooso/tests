namespace ServiceBox
{
    public class MockDataAccess : IDataAccess
    {
        public List<string> fileNames {  get; set; } = new List<string>();

        public IEnumerable<string> getFileNames() => fileNames;
    }
}
