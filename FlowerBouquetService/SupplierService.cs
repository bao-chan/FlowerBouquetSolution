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
	public class SuppplierService : ISupplierService
	{
		private readonly ISupplierRepo _supplierRepo;
		public SuppplierService(ISupplierRepo supplierRepo)
		{
			_supplierRepo = supplierRepo;
		}

		public async Task<bool> CreateSupplierAsync(Supplier Supplier)
		{
			return await _supplierRepo.CreateSupplierAsync(Supplier);
		}

		public async Task<bool> DeleteSupplierAsync(int Supplier)
		{
			return await _supplierRepo.DeleteSupplierAsync(Supplier);
		}

		public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
		{
			return await _supplierRepo.GetAllSuppliersAsync();
		}

		public async Task<Supplier?> GetSupplierByIdAsync(int Supplier)
		{
			return await _supplierRepo.GetSupplierByIdAsync(Supplier);
		}

		public async Task<bool> UpdateSupplierAsync(Supplier Supplier)
		{
			return await _supplierRepo.UpdateSupplierAsync(Supplier);
		}
	}
}
