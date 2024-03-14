using FlowerBouquetBussinessOject.Models;
using FlowerBouquetRepository.InterFace;
using FlowerBouquetService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetService
{
	public class FlowerBouquetsService : IFlowerBouquetService
	{
		private readonly IFlowerBouquetRepo _repo;
		public FlowerBouquetsService(IFlowerBouquetRepo repo) {
			_repo = repo;
		}
		public async Task<bool> CreateFlowerBouquetAsync(FlowerBouquet flowerBouquet)
		{
			return await _repo.CreateFlowerBouquetAsync(flowerBouquet);
		}

		public async Task<bool> DeleteFlowerBouquetAsync(int flowerBouquetId)
		{
			return await _repo.DeleteFlowerBouquetAsync(flowerBouquetId);
		}

		public List<FlowerBouquet> GetAllFlowerBouquetsAsync()
		{
			return _repo.GetAllFlowerBouquetsAsync();
		}

		public async Task<FlowerBouquet?> GetFlowerBouquetByIdAsync(int flowerBouquetId)
		{
			return await _repo.GetFlowerBouquetByIdAsync(flowerBouquetId);
		}

		public List<FlowerBouquet> SearchByName(string name)
		{
			return _repo.SearchByName(name);
		}

		public Task<bool> UpdateFlowerBouquetAsync(FlowerBouquet flowerBouquet)
		{
			return UpdateFlowerBouquetAsync(flowerBouquet);
		}
	}
}
