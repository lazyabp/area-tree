using Lazy.Abp.AreaTree.Regions;
using Lazy.Abp.AreaTree.Regions.Dtos;
using AutoMapper;

namespace Lazy.Abp.AreaTree
{
    public class AreaTreeApplicationAutoMapperProfile : Profile
    {
        public AreaTreeApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Region, RegionDto>();
            CreateMap<RegionCreateUpdateDto, Region>(MemberList.Source);
        }
    }
}
