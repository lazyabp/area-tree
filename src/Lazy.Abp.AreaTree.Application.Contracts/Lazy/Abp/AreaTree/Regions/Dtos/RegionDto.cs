using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaTree.Regions.Dtos
{
    [Serializable]
    public class RegionDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public bool IsActive { get; set; }

        public int DisplayOrder { get; set; }

        public string Code { get; set; }

        public int Level { get; set; }

        public Guid? ParentId { get; set; }

        public ICollection<RegionDto> Children { get; set; }
    }
}