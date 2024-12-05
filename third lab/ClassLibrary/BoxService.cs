namespace ServiceBox
{
    public class BoxService
    {
        private ILogService logService;
        private IMailService mailService;
        private IDataAccess dataAccess;
        private IReportManager reportManager;

        public BoxService(ILogService logService, IMailService mailService, IDataAccess dataAccess, IReportManager reportManager)
        {
            this.logService = logService;
            this.mailService = mailService;
            this.dataAccess = dataAccess;
            this.reportManager = reportManager;
        }

        public void Analize(string fileName)
        {
            try
            {
                var fileNames = dataAccess.getFileNames();

                if (!fileNames.Any())
                {
                    logService.LogError("No files retrieved from database.");
                    return;
                }

                reportManager.saveReport(fileNames);
            }
            catch(Exception ex)
            {
                mailService.sendMail("admin@example.com", ex.Message);
            }
        }
    }
}