using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.Sessions.Dto;

namespace FinTech.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
