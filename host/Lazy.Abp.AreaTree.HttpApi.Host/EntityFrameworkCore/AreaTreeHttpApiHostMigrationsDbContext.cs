using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    public class AreaTreeHttpApiHostMigrationsDbContext : AbpDbContext<AreaTreeHttpApiHostMigrationsDbContext>
    {
        public AreaTreeHttpApiHostMigrationsDbContext(DbContextOptions<AreaTreeHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAreaTree();
        }
    }
}
