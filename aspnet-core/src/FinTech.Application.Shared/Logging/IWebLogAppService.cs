using Abp.Application.Services;
using FinTech.Dto;
using FinTech.Logging.Dto;

namespace FinTech.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
