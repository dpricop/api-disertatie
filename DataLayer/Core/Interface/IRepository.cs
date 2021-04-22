using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		T GetById(int id);
		int Count();
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}