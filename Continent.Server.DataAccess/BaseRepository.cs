using System;
using System.Collections.Generic;

namespace Continent.Server.DataAccess
{
    public  abstract class BaseRepository<TEntity, TId> where TEntity : class
    {
        public void Add(TEntity entity)
        {
        }

        public void Edit(TEntity entity)
        {
        }

        public void Delete(TId id)
        {
        }

        public TEntity Get(TId id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetMany()
        {
            throw new NotImplementedException();
        }
    }
}
