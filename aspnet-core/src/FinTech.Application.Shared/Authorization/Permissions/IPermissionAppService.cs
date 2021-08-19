using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FinTech.Authorization.Permissions.Dto;

namespace FinTech.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
