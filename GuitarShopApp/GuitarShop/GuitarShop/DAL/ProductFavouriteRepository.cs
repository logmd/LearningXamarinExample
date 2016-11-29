using GuitarShop.BusinessObjects;
using GuitarShop.Infrastructure.UnitOfWork;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using GuitarShop.Infrastructure.Domain;

namespace GuitarShop.DAL
{
    public class ProductFavouriteRepository : IRepository<Favourite,int>, IUnitOfWorkRepository
    {
        private SQLiteConnection _database;
        private IUnitOfWork _unitOfWork;

        public ProductFavouriteRepository(IUnitOfWork unitOfWork)
        {
            _database = DependencyService.Get<ISQLite>().GetConnection();
            _database.CreateTable<Favourite>();
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Favourite> FindAll()
        {
            return _database.Table<Favourite>().ToList();
        }

        public Favourite FindBy(int id)
        {
            return _database.Table<Favourite>().FirstOrDefault(f => f.ProductNumber == id);
        }

        public void Add(Favourite entity)
        {
            _unitOfWork.RegisterNew(entity, this);
        }

        public void Save(Favourite entity)
        {
            _unitOfWork.RegisterAmended(entity, this);
        }

        public void Remove(Favourite entity)
        {
            _unitOfWork.RegisterDeleted(entity, this);
        }

        public void PersistCreationOf(IAggregateRoot entity)
        {
            _database.Insert(entity);
        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            _database.Update(entity);
        }

        public void PersistDeleteOf(IAggregateRoot entity)
        {
            _database.Delete(entity);
        }
    }
}
