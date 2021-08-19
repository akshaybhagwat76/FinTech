using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    [DependsOn(typeof(FinTechXamarinSharedModule))]
    public class FinTechXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechXamarinIosModule).GetAssembly());
        }
    }
}