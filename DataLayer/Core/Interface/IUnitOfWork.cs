using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiDisertatie.DataLayer
{
	public interface IUnitOfWork : IDisposable
	{
		int SaveChanges();
	}
}