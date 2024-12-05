namespace ServiceBox
{
    public interface IMailService
    {
        void sendMail(string destination, string message);
    }
}