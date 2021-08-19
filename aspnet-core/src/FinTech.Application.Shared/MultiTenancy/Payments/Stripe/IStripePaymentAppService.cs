using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.MultiTenancy.Payments.Dto;
using FinTech.MultiTenancy.Payments.Stripe.Dto;

namespace FinTech.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}