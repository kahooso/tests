using ServiceBox.interfaces;

namespace ServiceBox
{
    public class BoxService
    {
        private ILogService _logService;
        private IMailService _mailService;
        private IDataAccess _dataAccess;
        private IReportManager _reportManager;

        public BoxService(ILogService logService,
                            IMailService mailService,
                            IDataAccess dataAccess,
                            IReportManager reportManager)
        {
            _logService = logService;
            _mailService = mailService;
            _dataAccess = dataAccess;
            _reportManager = reportManager;
        }

        public void ScanAllFiles()
        {
            var fileNamesFromDB = _dataAccess.getFileNames();

            var reportData = new List<string>();

            foreach (var file in fileNamesFromDB)
            {
                try
                {
                    if (Path.GetExtension(file) != ".txt")
                    {
                        var message = $"FileExtension error: {file}";
                        _logService.LogError(message);
                    }

                    if (file.Length < 8)
                    {
                        var message = $"Filename too short: {file}";
                        _logService.LogError(message);
                    }
                }
                catch (Exception ex)
                {
                    _mailService.sendMail(ex.Message, "support@example.com");
                    reportData.Add(file);
                }
            }

            _reportManager.saveReport(reportData);
        }
    }
}