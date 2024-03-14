using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class FlowerBouquetsDAO : GenericDAO<FlowerBouquet>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public FlowerBouquetsDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
		public List<FlowerBouquet> SearchByName(string name)
		{
			return dbContext.FlowerBouquets.Where(f => f.FlowerBouquetName.Contains(name)).ToList();
		}
	}
}
