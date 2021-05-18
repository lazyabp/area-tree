using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Lazy.Abp.AreaTree.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AreaTreePageModel : AbpPageModel
    {
        protected AreaTreePageModel()
        {
            LocalizationResourceType = typeof(AreaTreeResource);
            ObjectMapperContext = typeof(AreaTreeWebModule);
        }
    }
}