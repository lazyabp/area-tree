using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Lazy.Abp.AreaTree
{
    public abstract class AreaTreeController : AbpController
    {
        protected AreaTreeController()
        {
            LocalizationResource = typeof(AreaTreeResource);
        }
    }
}
