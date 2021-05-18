using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lazy.Abp.AreaTree.Regions;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    [ConnectionStringName(AreaTreeDbProperties.ConnectionStringName)]
    public class AreaTreeDbContext : AbpDbContext<AreaTreeDbContext>, IAreaTreeDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Region> Regions { get; set; }

        public AreaTreeDbContext(DbContextOptions<AreaTreeDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAreaTree();
        }
    }
}
