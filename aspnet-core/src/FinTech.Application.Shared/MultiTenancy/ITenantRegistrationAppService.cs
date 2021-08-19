using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Editions.Dto;
using FinTech.MultiTenancy.Dto;

namespace FinTech.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}