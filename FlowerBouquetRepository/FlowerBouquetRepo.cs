using FlowerBouquetBussinessOject.Models;
using FlowerBouquetDAO;
using FlowerBouquetRepository.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository
{
	public class FlowerBouquetRepo : IFlowerBouquetRepo
	{
		private readonly FlowerBouquetsDAO _flowerBouquetDAO;

		public FlowerBouquetRepo()
		{
			_flowerBouquetDAO = new FlowerBouquetsDAO();
		}
		public async Task<bool> CreateFlowerBouquetAsync(FlowerBouquet flowerBouquet)
		{
			var result = await _flowerBouquetDAO.AddAsync(flowerBouquet) > 0;
			return result;
		}

		public async Task<bool> DeleteFlowerBouquetAsync(int id)
		{
			var result = await _flowerBouquetDAO.Delete( _flowerBouquetDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public List<FlowerBouquet> GetAllFlowerBouquetsAsync() 
		{ 
			var list =  _flowerBouquetDAO.GetAllAsync();
			return list;
		}


		public async Task<FlowerBouquet?> GetFlowerBouquetByIdAsync(int id)
		{
			var result =  _flowerBouquetDAO.GetByIdAsync(id);
			return result;
		}

		public List<FlowerBouquet> SearchByName(string name)
		{
			return _flowerBouquetDAO.SearchByName(name);
		}

		public async Task<bool> UpdateFlowerBouquetAsync(FlowerBouquet flowerBouquet)
		{
			var result = await _flowerBouquetDAO.Delete(flowerBouquet) > 0;
			return result;
		}
	}
}
