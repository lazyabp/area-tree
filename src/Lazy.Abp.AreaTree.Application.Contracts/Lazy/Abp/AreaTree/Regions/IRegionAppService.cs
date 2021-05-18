using System;
using Lazy.Abp.AreaTree.Regions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaTree.Regions
{
    public interface IRegionAppService :
        ICrudAppService< 
            RegionDto, 
            Guid,
            RegionListRequestDto,
            RegionCreateUpdateDto,
            RegionCreateUpdateDto>
    {

    }
}