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
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepo _customerRepo;

		public CustomerService(ICustomerRepo customerRepo)
		{
			_customerRepo = customerRepo;
		}
		public async Task<bool> CreateCustomerAsync(Customer customer)
		{
			return await _customerRepo.CreateCustomerAsync(customer);
		}

		public async Task<bool> DeleteCustomerAsync(int customerId)
		{
			return await _customerRepo.DeleteCustomerAsync(customerId);
		}

		public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
		{
			return await _customerRepo.GetAllCustomerAsync();
		}

		public async Task<Customer?> GetCustomerByIdAsync(int customerId)
		{
			return await _customerRepo.GetCustomerByIdAsync(customerId);
		}

		public Customer LoginByEmailAndPassword(string email, string password)
		{
			return _customerRepo.LoginByEmailAndPassword(email, password);
		}

		public async Task<bool> UpdateCustomerAsync(Customer customer)
		{
			return await _customerRepo.UpdateCustomerAsync(customer);
		}
	}
}
