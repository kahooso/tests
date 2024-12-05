namespace ServiceBox.Tests
{
    public class ServiceBoxTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test1()
        {
            var logService = new StubLogService();
            var mailService = new MockMailService();
            var dataAccess = new MockDataAccess();
            var reportManager = new MockReportManager();

            var service = new BoxService(logService, mailService, dataAccess, reportManager);
            service.Analize();

            Assert.AreEqual("No files retrieved from database.", logService.lastError);
        }
    }
}