using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    [DependsOn(typeof(FinTechCoreSharedModule))]
    public class FinTechApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechApplicationSharedModule).GetAssembly());
        }
    }
}