using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity FindById(int id);
        IQueryable<TEntity> GetAll();
        void Remove(TEntity item);
        void Update(TEntity item);
    }
}
