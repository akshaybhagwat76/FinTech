using Microsoft.Extensions.Configuration;

namespace FinTech.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
