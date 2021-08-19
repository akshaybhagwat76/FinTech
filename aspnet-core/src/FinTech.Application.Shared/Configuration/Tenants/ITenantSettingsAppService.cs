using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Configuration.Tenants.Dto;

namespace FinTech.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
