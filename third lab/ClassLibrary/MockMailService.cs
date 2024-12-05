namespace ServiceBox
{
    public class MockMailService : IMailService
    {
        public string? message;
        public string? destination;
        public void sendMail(string destination, string message)
        {
            this.message = message;
            this.destination = destination;
        }
    }
}