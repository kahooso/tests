namespace ServiceBox.interfaces
{
    public interface IMailService
    {
        public void sendMail(string message, string destination);
    }
}