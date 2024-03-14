using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class CustomerDAO : GenericDAO<Customer>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public CustomerDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
		public Customer LoginByEmailAndPassword(string email, string password)
		{
			return _dbContext.Customers.FirstOrDefault(aa => aa.Email.Equals(email) && aa.Password.Equals(password));
		}
	}
}
