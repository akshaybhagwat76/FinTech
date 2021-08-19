using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FinTech.Common.Dto;
using FinTech.Editions.Dto;

namespace FinTech.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}