using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaTree.MongoDB
{
    [DependsOn(
        typeof(AreaTreeDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class AreaTreeMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<AreaTreeMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
