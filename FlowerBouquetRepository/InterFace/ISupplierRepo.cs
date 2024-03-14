using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository.InterFace
{
	public interface ISupplierRepo
	{
		Task<IEnumerable<Supplier>> GetAllSuppliersAsync();

		Task<Supplier?> GetSupplierByIdAsync(int Supplier);

		Task<bool> CreateSupplierAsync(Supplier Supplier);

		Task<bool> UpdateSupplierAsync(Supplier Supplier);

		Task<bool> DeleteSupplierAsync(int Supplier);
	}
}
