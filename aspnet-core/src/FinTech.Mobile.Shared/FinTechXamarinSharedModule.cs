using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    [DependsOn(typeof(FinTechClientModule), typeof(AbpAutoMapperModule))]
    public class FinTechXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechXamarinSharedModule).GetAssembly());
        }
    }
}