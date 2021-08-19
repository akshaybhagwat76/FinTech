using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FinTech.Web.Public.Views
{
    public abstract class FinTechRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FinTechRazorPage()
        {
            LocalizationSourceName = FinTechConsts.LocalizationSourceName;
        }
    }
}
