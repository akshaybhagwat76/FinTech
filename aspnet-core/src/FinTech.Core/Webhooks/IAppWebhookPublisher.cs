using System.Threading.Tasks;
using FinTech.Authorization.Users;

namespace FinTech.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
