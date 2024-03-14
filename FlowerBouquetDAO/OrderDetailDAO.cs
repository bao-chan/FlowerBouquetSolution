using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class OrderDetailDAO : GenericDAO<OrderDetail>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public OrderDetailDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
	}
}
