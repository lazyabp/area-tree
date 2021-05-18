using Lazy.Abp.AreaTree.Regions.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Lazy.Abp.AreaTree.Regions
{
    [RemoteService(Name = AreaTreeRemoteServiceConsts.RemoteServiceName)]
    [Area("areatree")]
    [ControllerName("Region")]
    [Route("api/areatree/regions")]
    public class RegionController : AreaTreeController, IRegionAppService
    {
        private readonly IRegionAppService _service;

        public RegionController(IRegionAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<RegionDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<RegionDto>> GetListAsync(RegionListRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<RegionDto> CreateAsync(RegionCreateUpdateDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<RegionDto> UpdateAsync(Guid id, RegionCreateUpdateDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}
