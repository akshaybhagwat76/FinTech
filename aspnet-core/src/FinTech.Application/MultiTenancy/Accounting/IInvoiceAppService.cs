using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using FinTech.MultiTenancy.Accounting.Dto;

namespace FinTech.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
