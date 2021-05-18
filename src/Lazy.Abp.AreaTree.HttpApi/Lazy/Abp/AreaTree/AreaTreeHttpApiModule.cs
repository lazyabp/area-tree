﻿using Localization.Resources.AbpUi;
using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Lazy.Abp.AreaTree
{
    [DependsOn(
        typeof(AreaTreeApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AreaTreeHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AreaTreeHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AreaTreeResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
