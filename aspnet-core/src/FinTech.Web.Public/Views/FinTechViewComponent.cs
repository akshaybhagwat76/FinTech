using Abp.AspNetCore.Mvc.ViewComponents;

namespace FinTech.Web.Public.Views
{
    public abstract class FinTechViewComponent : AbpViewComponent
    {
        protected FinTechViewComponent()
        {
            LocalizationSourceName = FinTechConsts.LocalizationSourceName;
        }
    }
}