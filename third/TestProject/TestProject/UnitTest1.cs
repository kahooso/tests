using ServiceBox.mocks;
using ServiceBox.stubs;

namespace ServiceBox.Tests
{
    public class ServiceBoxTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Test_Files()
        {
            StubLogService logService = new();
            MockMailService mailService = new();
            MockReportManager report = new();
            StubDataAccess dataAccess = new();

            BoxService boxService = new(logService, mailService, dataAccess, report);

            boxService.ScanAllFiles();

            Assert.That(mailService.message, Is.EqualTo("FileExtension error: " +
                report.reportData[0]).Or.EqualTo("FileExtension error: " +
                report.reportData[1]).Or.EqualTo("FileExtension error: " +
                report.reportData[2]));

            Assert.That(report.reportData, Is.TypeOf<List<string>>());
        }
    }
}