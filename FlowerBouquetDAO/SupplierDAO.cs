using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class SupplierDAO : GenericDAO<Supplier>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public SupplierDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
	}
}
