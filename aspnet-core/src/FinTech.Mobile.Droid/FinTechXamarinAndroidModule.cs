using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    [DependsOn(typeof(FinTechXamarinSharedModule))]
    public class FinTechXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechXamarinAndroidModule).GetAssembly());
        }
    }
}