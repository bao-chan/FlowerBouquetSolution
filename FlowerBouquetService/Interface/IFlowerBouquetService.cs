using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetService.Interface
{
	public interface IFlowerBouquetService
	{
		List<FlowerBouquet> GetAllFlowerBouquetsAsync();

		Task<FlowerBouquet?> GetFlowerBouquetByIdAsync(int flowerBouquetId);

		Task<bool> CreateFlowerBouquetAsync(FlowerBouquet flowerBouquet);

		Task<bool> UpdateFlowerBouquetAsync(FlowerBouquet flowerBouquet);

		Task<bool> DeleteFlowerBouquetAsync(int flowerBouquetId);
		List<FlowerBouquet> SearchByName(string name);
	}
}
