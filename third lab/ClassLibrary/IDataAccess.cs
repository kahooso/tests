namespace ServiceBox
{
    public interface IDataAccess
    {
        IEnumerable<string> getFileNames();
    }
}
