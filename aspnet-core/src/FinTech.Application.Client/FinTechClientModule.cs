using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FinTech
{
    public class FinTechClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FinTechClientModule).GetAssembly());
        }
    }
}
