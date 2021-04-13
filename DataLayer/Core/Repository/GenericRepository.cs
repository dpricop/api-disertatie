using ApiDisertatie.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer
{
    public partial class GenericRepository<T> where T : class
    {
        private readonly DatabaseContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        #region - Methods
        public virtual IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public virtual IQueryable<T> GetAllByPage(int skip, int take)
        {
            return _dbSet.Skip(skip).Take(take).AsQueryable();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public int Add(T entity)
        {
            _dbSet.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        public int Delete(T entity)
        {
            _dbSet.Remove(entity);
            return _dbContext.SaveChanges();
        }
        #endregion
    }
}
