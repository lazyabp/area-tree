using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaTree.MongoDB
{
    [ConnectionStringName(AreaTreeDbProperties.ConnectionStringName)]
    public interface IAreaTreeMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
