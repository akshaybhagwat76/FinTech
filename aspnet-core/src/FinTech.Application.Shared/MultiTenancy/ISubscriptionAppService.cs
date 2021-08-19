using System.Threading.Tasks;
using Abp.Application.Services;

namespace FinTech.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
