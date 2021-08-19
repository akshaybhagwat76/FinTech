using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Configuration.Host.Dto;

namespace FinTech.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
