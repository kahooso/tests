namespace ServiceBox
{
    public class MockMailService : IMailService
    {
        public string? message;
        public string? destination;

        public void sendMail(string message, string destination)
        {
            this.message = message;
            this.destination = destination;
        }
    }
}