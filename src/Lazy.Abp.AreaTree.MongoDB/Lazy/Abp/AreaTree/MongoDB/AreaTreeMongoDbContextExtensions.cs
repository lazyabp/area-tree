using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaTree.MongoDB
{
    public static class AreaTreeMongoDbContextExtensions
    {
        public static void ConfigureAreaTree(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AreaTreeMongoModelBuilderConfigurationOptions(
                AreaTreeDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}