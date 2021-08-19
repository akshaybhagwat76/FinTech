using System.Threading.Tasks;
using Abp.Dependency;

namespace FinTech.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}