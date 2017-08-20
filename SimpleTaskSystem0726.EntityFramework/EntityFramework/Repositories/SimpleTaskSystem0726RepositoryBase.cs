using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SimpleTaskSystem0726.EntityFramework.Repositories
{
    public abstract class SimpleTaskSystem0726RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SimpleTaskSystem0726DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SimpleTaskSystem0726RepositoryBase(IDbContextProvider<SimpleTaskSystem0726DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SimpleTaskSystem0726RepositoryBase<TEntity> : SimpleTaskSystem0726RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SimpleTaskSystem0726RepositoryBase(IDbContextProvider<SimpleTaskSystem0726DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
