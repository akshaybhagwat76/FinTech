using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using FinTech.EntityFrameworkCore;

namespace FinTech.HealthChecks
{
    public class FinTechDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public FinTechDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("FinTechDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("FinTechDbContext could not connect to database"));
        }
    }
}
