using ApiDisertatie.DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer.Repository
{
    public partial class GenericRepository<T> : IRepository<T> where T : class
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
        public int Count()
        {
            return _dbSet.Count();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        #endregion
    }
}
