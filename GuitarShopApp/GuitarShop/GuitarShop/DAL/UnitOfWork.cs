using GuitarShop.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarShop.Infrastructure.Domain;
using SQLite;
using Xamarin.Forms;

namespace GuitarShop.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private SQLiteConnection _database;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> addedEntities;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> amendedEntities;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> deletedEntities;

        public UnitOfWork(ISQLite sqlLite)
        {
            _database = sqlLite.GetConnection();
        }

        public void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository repository)
        {
            if(!amendedEntities.ContainsKey(entity))
            {
                amendedEntities.Add(entity, repository);
            }
        }

        public void RegisterDeleted(IAggregateRoot entity, IUnitOfWorkRepository repository)
        {
            if (!deletedEntities.ContainsKey(entity))
            {
                deletedEntities.Add(entity, repository);
            }
        }

        public void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository repository)
        {
            if (!addedEntities.ContainsKey(entity))
            {
                addedEntities.Add(entity, repository);
            }
        }

        public void Commit()
        {
            _database.BeginTransaction();

            try
            {
                foreach(var entity in addedEntities.Keys)
                {
                    addedEntities[entity].PersistCreationOf(entity);
                }

                foreach (var entity in amendedEntities.Keys)
                {
                    amendedEntities[entity].PersistUpdateOf(entity);
                }

                foreach (var entity in deletedEntities.Keys)
                {
                    deletedEntities[entity].PersistDeleteOf(entity);
                }

                _database.Commit();
            }
            catch (Exception ex)
            {
                // Log error
                _database.Rollback();
            }
        }

    }
}
