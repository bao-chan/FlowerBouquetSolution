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
	public class SupplierRepo : ISupplierRepo
	{
		private readonly SupplierDAO _supplierDAO;

		public SupplierRepo()
		{
			_supplierDAO = new SupplierDAO();
		}
		public async Task<bool> CreateSupplierAsync(Supplier supplier)
		{
			var result = await _supplierDAO.AddAsync(supplier) > 0;
			return result;
		}

		public async Task<bool> DeleteSupplierAsync(int id)
		{
			var result = await _supplierDAO.Delete( _supplierDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
		{
			var list =  _supplierDAO.GetAllAsync();
			return list;
		}


		public async Task<Supplier?> GetSupplierByIdAsync(int id)
		{
			var result =  _supplierDAO.GetByIdAsync(id);
			return result;
		}

		public async Task<bool> UpdateSupplierAsync(Supplier supplier)
		{
			var result = await _supplierDAO.Delete(supplier) > 0;
			return result;
		}
	}
}
