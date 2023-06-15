using FN.Store.Domain.Entities;
using System.Collections.Generic;

namespace FN.Store.Domain.Contratcts.Repositories
{
    public interface IRepository<T> : System.IDisposable where T : Entity
    {
        IEnumerable<T> Get();
        T Get(int id);

        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);

    }
}
