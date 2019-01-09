using System;

namespace Continent.Server.Model
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
