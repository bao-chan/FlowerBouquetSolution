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
	public class OrderRepo : IOrderRepo
	{
		private readonly OrderDAO _orderDAO;

		public OrderRepo()
		{
			_orderDAO = new OrderDAO();
		}
		public async Task<bool> CreateOrderAsync(Order order)
		{
			var result = await _orderDAO.AddAsync(order) > 0;
			return result;
		}

		public async Task<bool> DeleteOrderAsync(int id)
		{
			var result = await _orderDAO.Delete( _orderDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public async Task<IEnumerable<Order>> GetAllOrdersAsync()
		{
			var list =  _orderDAO.GetAllAsync();
			return list;
		}


		public async Task<Order?> GetOrderByIdAsync(int id)
		{
			var result =  _orderDAO.GetByIdAsync(id);
			return result;
		}

		public async Task<bool> UpdateOrderAsync(Order order)
		{
			var result = await _orderDAO.Delete(order) > 0;
			return result;
		}
	}
}
