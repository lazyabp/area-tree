using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Lazy.Abp.AreaTree.Regions;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    [ConnectionStringName(AreaTreeDbProperties.ConnectionStringName)]
    public interface IAreaTreeDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Region> Regions { get; set; }
    }
}
