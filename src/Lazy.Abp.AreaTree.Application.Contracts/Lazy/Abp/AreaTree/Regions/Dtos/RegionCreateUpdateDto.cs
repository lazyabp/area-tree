using System;

namespace Lazy.Abp.AreaTree.Regions.Dtos
{
    [Serializable]
    public class RegionCreateUpdateDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        public Guid? ParentId { get; set; }
    }
}