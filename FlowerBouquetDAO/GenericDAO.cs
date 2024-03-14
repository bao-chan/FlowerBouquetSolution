using FlowerBouquetBussinessOject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class GenericDAO<T> where T : class
	{
		protected readonly FUFlowerBouquetManagementContext _dbContext;

		protected GenericDAO()
		{
			_dbContext = new FUFlowerBouquetManagementContext();
		}

		public T GetByIdAsync(int id)
		{
			return _dbContext.Set<T>().Find(id);
		}

		public List<T> GetAllAsync()
		{
			return _dbContext.Set<T>().ToList();
		}

		public async Task<int> AddAsync(T entity)
		{
			_dbContext.Set<T>().AddAsync(entity);
			return _dbContext.SaveChanges();
		}

		public async Task<int> Update(T entity)
		{
			_dbContext.Set<T>().Update(entity);
			return _dbContext.SaveChanges();
		}

		public async Task<int> Delete(T entity)
		{
			_dbContext.Set<T>().Remove(entity);
			return _dbContext.SaveChanges();
		}
	}
}
