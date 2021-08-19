using Abp.AspNetCore.Mvc.Views;

namespace FinTech.Web.Views
{
    public abstract class FinTechRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FinTechRazorPage()
        {
            LocalizationSourceName = FinTechConsts.LocalizationSourceName;
        }
    }
}
