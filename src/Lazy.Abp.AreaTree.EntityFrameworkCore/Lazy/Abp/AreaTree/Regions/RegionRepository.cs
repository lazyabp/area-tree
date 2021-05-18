using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Lazy.Abp.AreaTree.EntityFrameworkCore;
using Lazy.Abp.Tree;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Lazy.Abp.AreaTree.Regions
{
    public class RegionRepository : EfCoreTreeRepository<IAreaTreeDbContext, Region>, IRegionRepository
    {
        public RegionRepository(IDbContextProvider<IAreaTreeDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Region>> WithDetailsAsync()
        {
            return (await base.WithDetailsAsync())
                .Include(x => x.Parent)
                .Include(x => x.Children);
        }

        public async Task<int> GetCountAsync(
            Guid? parentId = null,
            int? level = null,
            string code = null,
            bool? isActive = null,
            string filter = null,
            bool filterParent = false,
            bool includeDetails = false,
            CancellationToken cancellationToken = default
        )
        {
            var query = await GetQuery(parentId, level, code, isActive, filter, filterParent, includeDetails);

            return await query
                .CountAsync(GetCancellationToken(cancellationToken));
        }

        public async Task<List<Region>> GetListAsync(
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
        )
        {
            var query = await GetQuery(parentId, level, code, isActive, filter, filterParent, includeDetails);

            return await query
                .OrderBy(sorting ?? "DisplayOrder ASC, CreationTime ASC")
                .PageBy(skipCount, maxResultCount)
                .ToListAsync(GetCancellationToken(cancellationToken));
        }

        protected async Task<IQueryable<Region>> GetQuery(
            Guid? parentId = null,
            int? level = null,
            string code = null,
            bool? isActive = null,
            string filter = null,
            bool filterParent = false,
            bool includeDetails = false
        )
        {
            var query = await GetQueryableAsync();

            return query
                .IncludeIf(includeDetails, q => q.Children)
                .WhereIf(filterParent, e => e.ParentId == parentId)
                .WhereIf(level.HasValue, e => e.Level == level)
                .WhereIf(!code.IsNullOrEmpty(), e => e.Code == code)
                .WhereIf(isActive.HasValue, e => e.IsActive == isActive)
                .WhereIf(
                    !filter.IsNullOrEmpty(),
                    e => false
                    || e.Name.Contains(filter)
                    || e.DisplayName.Contains(filter)
                );
        }
    }
}