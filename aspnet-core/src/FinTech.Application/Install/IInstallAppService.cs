using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Install.Dto;

namespace FinTech.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}