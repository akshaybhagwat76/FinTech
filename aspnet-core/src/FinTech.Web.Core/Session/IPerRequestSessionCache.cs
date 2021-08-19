using System.Threading.Tasks;
using FinTech.Sessions.Dto;

namespace FinTech.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
