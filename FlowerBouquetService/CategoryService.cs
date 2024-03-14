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
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepo _categoryRepo;

		public CategoryService(ICategoryRepo categoryRepo)
		{
			_categoryRepo = categoryRepo;
		}
		public async Task<bool> CreateCategoryAsync(Category category)
		{
			return await _categoryRepo.CreateCategoryAsync(category);
		}

		public async Task<bool> DeleteCategoryAsync(int categoryId)
		{
			return await _categoryRepo.DeleteCategoryAsync(categoryId);
		}

		public async Task<IEnumerable<Category>> GetAllCategorysAsync()
		{
			return await _categoryRepo.GetAllCategorysAsync();
		}

		public async Task<Category?> GetCategoryByIdAsync(int categoryId)
		{
			return await GetCategoryByIdAsync(categoryId);
		}

		public async Task<bool> UpdateCategoryAsync(Category category)
		{
			return await _categoryRepo.UpdateCategoryAsync(category);
		}
	}
}
