using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FinTech.EntityFrameworkCore
{
    public static class FinTechDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FinTechDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FinTechDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}