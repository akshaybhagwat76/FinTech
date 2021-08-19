using System.Threading.Tasks;
using Abp.Application.Services;
using FinTech.MultiTenancy.Payments.PayPal.Dto;

namespace FinTech.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
