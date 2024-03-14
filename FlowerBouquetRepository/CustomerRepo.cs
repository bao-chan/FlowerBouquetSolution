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
	public class CustomerRepo : ICustomerRepo
	{
		private readonly CustomerDAO _customerDAO;

		public CustomerRepo( )
		{
			_customerDAO = new CustomerDAO();
		}
		public async Task<bool> CreateCustomerAsync(Customer category)
		{
			var result = await _customerDAO.AddAsync(category) > 0;
			return result;
		}

		public async Task<bool> DeleteCustomerAsync(int id)
		{
			var result = await _customerDAO.Delete( _customerDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
		{
			var list =  _customerDAO.GetAllAsync();
			return list;
		}

		public async Task<Customer?> GetCustomerByIdAsync(int customerId)
		{
			var result =  _customerDAO.GetByIdAsync(customerId);
			return result;
		}

		public Customer LoginByEmailAndPassword(string email, string password)
		{
			return _customerDAO.LoginByEmailAndPassword(email, password);
		}

		public async Task<bool> UpdateCustomerAsync(Customer customer)
		{
			var result = await _customerDAO.Delete(customer) > 0;
			return result;
		}
		
	}
}
