using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Lazy.Abp.AreaTree.Web.Menus
{
    public class AreaTreeMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(AreaTreeMenus.Prefix, displayName: "AreaTree", "~/AreaTree", icon: "fa fa-globe"));

            return Task.CompletedTask;
        }
    }
}