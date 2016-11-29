using GuitarApp.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository repository);
        void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository repository);
        void RegisterDeleted(IAggregateRoot entity, IUnitOfWorkRepository repository);
        void Commit();
    }
}
