using System.Collections.Generic;

namespace ForwardingProject.Domain.Abstract
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Collection { get; }
        void Add(TEntity entity);
        void Edit(TEntity entity);
        void Delete(int id);
    }
}
