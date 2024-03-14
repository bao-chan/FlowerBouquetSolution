using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository.InterFace
{
	public interface ICategoryRepo
	{
		Task<IEnumerable<Category>> GetAllCategorysAsync();

		Task<Category?> GetCategoryByIdAsync(int categoryId);

		Task<bool> CreateCategoryAsync(Category category);

		Task<bool> UpdateCategoryAsync(Category category);

		Task<bool> DeleteCategoryAsync(int categoryId);
	}
}
