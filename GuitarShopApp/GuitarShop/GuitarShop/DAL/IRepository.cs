using System.Collections.Generic;
using GuitarApp.Infrastructure.Domain;

namespace GuitarShop.DAL
{
    public interface IRepository<T, Id>
        where T : IAggregateRoot
    {
        T FindBy(Id id);
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Save(T entity);
        void Remove(T entity);
    }
}