using Abp.Domain.Services;

namespace FinTech
{
    public abstract class FinTechDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FinTechDomainServiceBase()
        {
            LocalizationSourceName = FinTechConsts.LocalizationSourceName;
        }
    }
}
