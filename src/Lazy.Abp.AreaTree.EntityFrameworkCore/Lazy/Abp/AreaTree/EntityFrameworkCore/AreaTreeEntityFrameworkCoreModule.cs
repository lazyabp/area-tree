using Lazy.Abp.AreaTree.Regions;
using Lazy.Abp.Tree.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    [DependsOn(
        typeof(AreaTreeDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(TreeEntityFrameworkCoreModule)
    )]
    public class AreaTreeEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AreaTreeDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Region, RegionRepository>();
                options.AddDefaultTreeRepositories();
                options.TreeEntity<Region>(x => x.CodeLength = 5);
            });
        }
    }
}
