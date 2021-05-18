using Lazy.Abp.Tree;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Lazy.Abp.AreaTree.Regions
{
    public class Region : FullAuditedAggregateRoot<Guid>, ITree<Region>
    {
        public string Name { get; private set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; private set; }
        public int DisplayOrder { get; private set; }
        public string Code { get; set; }
        public int Level { get; set; }
        public Guid? ParentId { get; set; }
        public Region Parent { get; set; }
        public ICollection<Region> Children { get; set; }

        protected Region()
        {
        }

        public Region(
            Guid id,
            string name,
            string displayName,
            bool isActive,
            int displayOrder,
            Guid? parentId
        ) : base(id)
        {
            Name = name;
            DisplayName = displayName;
            IsActive = isActive;
            DisplayOrder = displayOrder;
            ParentId = parentId;
            Children = new Collection<Region>();
        }
    }
}
