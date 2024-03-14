using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class OrderDAO : GenericDAO<Order>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public OrderDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
	}
}
