using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaTree.Regions.Dtos
{
    public class RegionListRequestDto : PagedAndSortedResultRequestDto
    {
        public Guid? ParentId { get; set; }

        public int? Level { get; set; }

        public bool? IsActive { get; set; }

        public string Code { get; set; }

        public string Filter { get; set; }

        public bool FilterParent { get; set; }

        public bool IncludeDetails { get; set; }
    }
}
