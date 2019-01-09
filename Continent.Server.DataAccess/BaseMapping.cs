using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using Continent.Server.Model;

namespace Continent.Server.DataAccess
{
    internal class BaseMapping<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity<Guid>
    {
        public BaseMapping()
        {
            HasKey(e => e.Id).Property(e => e.Id).HasColumnType(SqlDbType.UniqueIdentifier.ToString()).IsRequired();
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.CreationTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            Property(e => e.LastUpdateTime).HasColumnType(SqlDbType.DateTime.ToString()).IsRequired();
            Property(e => e.IsDeleted).HasColumnType(SqlDbType.Bit.ToString()).IsRequired();
        }
    }
}
