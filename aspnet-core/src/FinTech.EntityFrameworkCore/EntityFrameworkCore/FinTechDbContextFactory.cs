using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using FinTech.Configuration;
using FinTech.Web;

namespace FinTech.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class FinTechDbContextFactory : IDesignTimeDbContextFactory<FinTechDbContext>
    {
        public FinTechDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<FinTechDbContext>();
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder(),
                addUserSecrets: true
            );

            FinTechDbContextConfigurer.Configure(builder, configuration.GetConnectionString(FinTechConsts.ConnectionStringName));

            return new FinTechDbContext(builder.Options);
        }
    }
}