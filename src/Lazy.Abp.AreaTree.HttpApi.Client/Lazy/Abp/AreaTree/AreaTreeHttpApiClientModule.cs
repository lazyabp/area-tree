using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Lazy.Abp.AreaTree
{
    [DependsOn(
        typeof(AreaTreeApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class AreaTreeHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "AreaTree";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AreaTreeApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
