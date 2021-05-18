using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;
using Lazy.Abp.Tree;

namespace Lazy.Abp.AreaTree
{
    [DependsOn(
        typeof(AbpValidationModule),
        typeof(TreeDomainSharedModule)
    )]
    public class AreaTreeDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AreaTreeDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AreaTreeResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/AreaTree");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("AreaTree", typeof(AreaTreeResource));
            });
        }
    }
}
