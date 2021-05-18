using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaTree.MongoDB
{
    [ConnectionStringName(AreaTreeDbProperties.ConnectionStringName)]
    public class AreaTreeMongoDbContext : AbpMongoDbContext, IAreaTreeMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAreaTree();
        }
    }
}