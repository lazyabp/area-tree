using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Lazy.Abp.AreaTree.Permissions;
using Lazy.Abp.AreaTree.Regions.Dtos;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Lazy.Abp.AreaTree.Regions
{
    public class RegionAppService : 
        CrudAppService<Region, RegionDto, Guid, RegionListRequestDto, RegionCreateUpdateDto, RegionCreateUpdateDto>,
        IRegionAppService
    {
        protected override string GetPolicyName { get; set; } = AreaTreePermissions.Region.Default;
        protected override string GetListPolicyName { get; set; } = AreaTreePermissions.Region.Default;
        protected override string CreatePolicyName { get; set; } = AreaTreePermissions.Region.Create;
        protected override string UpdatePolicyName { get; set; } = AreaTreePermissions.Region.Update;
        protected override string DeletePolicyName { get; set; } = AreaTreePermissions.Region.Delete;

        private readonly IRegionRepository _repository;
        
        public RegionAppService(IRegionRepository repository) : base(repository)
        {
            _repository = repository;
        }
        
        [AllowAnonymous]
        public override Task<RegionDto> GetAsync(Guid id)
        {
            return base.GetAsync(id);
        }

        [AllowAnonymous]
        public override async Task<PagedResultDto<RegionDto>> GetListAsync(RegionListRequestDto input)
        {
            var count = await _repository.GetCountAsync(input.ParentId, input.Level, 
                input.Code, input.IsActive, input.Filter, input.FilterParent, input.IncludeDetails);

            var list = await _repository.GetListAsync(input.ParentId, input.Level, input.Code, input.IsActive,
                input.Filter, input.FilterParent, input.IncludeDetails, input.MaxResultCount, input.SkipCount, input.Sorting);

            return new PagedResultDto<RegionDto>(
                count,
                ObjectMapper.Map<List<Region>, List<RegionDto>>(list)
            );
        }
    }
}
