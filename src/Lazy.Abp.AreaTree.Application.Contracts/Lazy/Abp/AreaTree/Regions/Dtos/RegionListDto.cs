using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaTree.Regions.Dtos
{
    [Serializable]
    public class RegionListDto : EntityDto<Guid>
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string Code { get; set; }

        public int Level { get; set; }

        public Guid? ParentId { get; set; }
    }
}