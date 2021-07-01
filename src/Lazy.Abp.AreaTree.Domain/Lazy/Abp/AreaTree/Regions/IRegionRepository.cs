using Lazy.Abp.Tree;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Lazy.Abp.AreaTree.Regions
{
    public interface IRegionRepository : ITreeRepository<Region>
    {
        Task<List<Region>> FindByIdsAsync(
            IEnumerable<Guid> ids, 
            bool includeDtails = false, 
            CancellationToken cancellationToken = default
        );

        Task<int> GetCountAsync(
            Guid? parentId = null,
            int? level = null,
            string code = null,
            bool? isActive = null,
            string filter = null,
            bool filterParent = false,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        );

        Task<List<Region>> GetListAsync(
            Guid? parentId = null,
            int? level = null,
            string code = null,
            bool? isActive = null,
            string filter = null,
            bool filterParent = false,
            bool includeDetails = false,
            int maxResultCount = 10,
            int skipCount = 0,
            string sorting = null,
            CancellationToken cancellationToken = default
        );
    }
}