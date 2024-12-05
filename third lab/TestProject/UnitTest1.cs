namespace ServiceBox.Tests
{
    [TestFixture]
    public class ServiceBoxTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test1()
        {
            var logService = new MockLogService();
            var mailService = new MockMailService();
            var dataAccess = new MockDataAccess();
            var reportManager = new MockReportManager();

            var service = new BoxService(logService, mailService, dataAccess, reportManager);
            service.Analize("SomeFile.log");

            Assert.That(logService.lastError, Is.EqualTo("No files retrieved from database."));
        }
    }
}