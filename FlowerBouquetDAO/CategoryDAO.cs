﻿using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetDAO
{
	public class CategoryDAO : GenericDAO<Category>
	{
		private readonly FUFlowerBouquetManagementContext dbContext = null;

		public CategoryDAO()
		{
			if (dbContext == null)
			{
				dbContext = new FUFlowerBouquetManagementContext();
			}
		}
	}
}
