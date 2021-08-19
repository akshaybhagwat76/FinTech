using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FinTech.Authorization;

namespace FinTech
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(FinTechApplicationSharedModule),
        typeof(FinTechCoreModule)
        )]
    public class FinTechApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechApplicationModule).GetAssembly());
        }
    }
}