using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FinTech.Configure;
using FinTech.Startup;
using FinTech.Test.Base;

namespace FinTech.GraphQL.Tests
{
    [DependsOn(
        typeof(FinTechGraphQLModule),
        typeof(FinTechTestBaseModule))]
    public class FinTechGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechGraphQLTestModule).GetAssembly());
        }
    }
}