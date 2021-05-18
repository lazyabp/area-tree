using Volo.Abp.Reflection;

namespace Lazy.Abp.AreaTree.Permissions
{
    public class AreaTreePermissions
    {
        public const string GroupName = "AreaTree";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AreaTreePermissions));
        }

        public class Region
        {
            public const string Default = GroupName + ".Region";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
