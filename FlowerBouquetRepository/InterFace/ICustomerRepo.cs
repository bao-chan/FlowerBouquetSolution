using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository.InterFace
{
	public interface ICustomerRepo
	{
		Task<IEnumerable<Customer>> GetAllCustomerAsync();

		Task<Customer?> GetCustomerByIdAsync(int customerId);
		Customer LoginByEmailAndPassword(string email, string password);

		Task<bool> CreateCustomerAsync(Customer customer);

		Task<bool> UpdateCustomerAsync(Customer customer);

		Task<bool> DeleteCustomerAsync(int customerId);
	}
}
