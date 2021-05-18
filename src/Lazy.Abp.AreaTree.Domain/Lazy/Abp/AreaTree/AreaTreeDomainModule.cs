using Lazy.Abp.Tree;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaTree
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AreaTreeDomainSharedModule),
        typeof(TreeDomainModule)
    )]
    public class AreaTreeDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.TryAddTransient(typeof(ITreeCodeGenerator<>), typeof(TreeCodeGenerator<>));
        }
    }
}
