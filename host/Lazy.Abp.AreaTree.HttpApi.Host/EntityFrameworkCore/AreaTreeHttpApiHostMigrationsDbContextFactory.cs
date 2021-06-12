using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    public class AreaTreeHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AreaTreeHttpApiHostMigrationsDbContext>
    {
        public AreaTreeHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AreaTreeHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("AreaTree"));

            return new AreaTreeHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
