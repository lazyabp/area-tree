using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Lazy.Abp.AreaTree.MongoDB
{
    public class AreaTreeMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AreaTreeMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}