using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaTree
{
    public abstract class AreaTreeAppService : ApplicationService
    {
        protected AreaTreeAppService()
        {
            LocalizationResource = typeof(AreaTreeResource);
            ObjectMapperContext = typeof(AreaTreeApplicationModule);
        }
    }
}
