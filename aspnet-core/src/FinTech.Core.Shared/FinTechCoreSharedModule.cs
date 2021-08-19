using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    public class FinTechCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechCoreSharedModule).GetAssembly());
        }
    }
}