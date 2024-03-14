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
	public class CategoryRepo : ICategoryRepo
	{
		private readonly CategoryDAO _categoryDAO;

		public CategoryRepo()
		{
			_categoryDAO = new CategoryDAO();
		}
		public async Task<bool> CreateCategoryAsync(Category category)
		{
			var result = await _categoryDAO.AddAsync(category) > 0;
			return result;
		}

		public async Task<bool> DeleteCategoryAsync(int id)
		{
			var result = await _categoryDAO.Delete( _categoryDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public async Task<IEnumerable<Category>> GetAllCategorysAsync()
		{
			var categories =  _categoryDAO.GetAllAsync();
			return categories;
		}

		public async Task<Category?> GetCategoryByIdAsync(int categoryId)
		{
			var list =  _categoryDAO.GetByIdAsync(categoryId);
			return list;
		}

		public async Task<bool> UpdateCategoryAsync(Category category)
		{
			var result = await _categoryDAO.Delete(category) > 0;
			return result;
		}
	}
}
