using Lazy.Abp.AreaTree.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lazy.Abp.AreaTree.Permissions
{
    public class AreaTreePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AreaTreePermissions.GroupName, L("Permission:AreaTree"));

            var regionPermission = myGroup.AddPermission(AreaTreePermissions.Region.Default, L("Permission:Region"));
            regionPermission.AddChild(AreaTreePermissions.Region.Create, L("Permission:Create"));
            regionPermission.AddChild(AreaTreePermissions.Region.Update, L("Permission:Update"));
            regionPermission.AddChild(AreaTreePermissions.Region.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AreaTreeResource>(name);
        }
    }
}
