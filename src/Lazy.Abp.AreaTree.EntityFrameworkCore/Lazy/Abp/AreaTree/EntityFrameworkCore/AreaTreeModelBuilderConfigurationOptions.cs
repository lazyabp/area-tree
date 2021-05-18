using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Lazy.Abp.AreaTree.EntityFrameworkCore
{
    public class AreaTreeModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AreaTreeModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}