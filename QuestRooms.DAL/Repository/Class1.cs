using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestRooms.DAL.Repository
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _context;
        DbSet<TEntity> _dbSet;

        public EFGenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}
