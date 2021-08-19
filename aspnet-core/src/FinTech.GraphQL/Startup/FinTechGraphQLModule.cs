using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech.Startup
{
    [DependsOn(typeof(FinTechCoreModule))]
    public class FinTechGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}