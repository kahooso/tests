namespace ServiceBox
{
    public class BoxService
    {
        private ILogService _logService;
        private IMailService _mailService;
        private IDataAccess _dataAccess;
        private IReportManager _reportManager;

        public BoxService(  ILogService logService, 
                            IMailService mailService, 
                            IDataAccess dataAccess, 
                            IReportManager reportManager)
        {
            _logService = logService;
            _mailService = mailService;
            _dataAccess = dataAccess;
            _reportManager = reportManager;
        }

        public void Analize(string fileName)
        {
            var fileNames = _dataAccess.getFileNames();
            var reportData = new List<string>();

            foreach ( var file in fileNames )
            {

                try
                {
                    if (fileName.Length < 8)
                        _logService.LogError("Filename too short: " + fileName);

                    if (Path.GetExtension(fileName) != ".txt")
                        _logService.LogError("FileExtension error: " + fileName);
                
                    reportData.Add(fileName);
                }
                catch (Exception ex)
                {
                    _mailService.sendMail(ex.Message, "some@mail.com");
                }
            }

            _reportManager.saveReport(reportData);
        }
    }
}