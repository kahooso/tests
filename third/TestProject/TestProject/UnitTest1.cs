namespace ServiceBox.Tests
{
    public class ServiceBoxTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            StubLogService stubLogService = new StubLogService();
            MockMailService mailService = new MockMailService();

            BoxService box = new BoxService(stubLogService, mailService);

            string fileName = "SomeFile.log";
            box.Analize(fileName);

            Assert.That(mailService.message, Is.EqualTo("FileExtension error: " + fileName));

            Assert.That(mailService.message, Is.EqualTo("FileExtension error: " +
                report.reportdata[0].Or.EqualTo("FileExtension error: " +
                report.reportdata[1].Or.EqualTo("FileExtension error: " +
                report.reportData[2]));

            Assert.That(report.reportdata, Is.TypeOf<List<string>>());
        
        }
    }
}

