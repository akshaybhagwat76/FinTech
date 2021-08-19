using System.Threading.Tasks;
using Abp.Webhooks;

namespace FinTech.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
