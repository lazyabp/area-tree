using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Lazy.Abp.AreaTree
{
    [DependsOn(
        typeof(AreaTreeDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AreaTreeApplicationContractsModule : AbpModule
    {

    }
}
