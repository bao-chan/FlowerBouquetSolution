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
	public class OrderDetailRepo : IOrderDetailRepo
	{
		private readonly OrderDetailDAO _orderDetailDAO;

		public OrderDetailRepo()
		{
			_orderDetailDAO = new OrderDetailDAO();
		}
		public async Task<bool> CreateOrderDetailAsync(OrderDetail orderDetail)
		{
			var result = await _orderDetailDAO.AddAsync(orderDetail) > 0;
			return result;
		}

		public async Task<bool> DeleteOrderDetailAsync(int id)
		{
			var result = await _orderDetailDAO.Delete( _orderDetailDAO.GetByIdAsync(id)) > 0;
			return result;
		}

		public async Task<IEnumerable<OrderDetail>> GetAllOrderDetailsAsync()
		{
			var list =  _orderDetailDAO.GetAllAsync();
			return list;
		}


		public async Task<OrderDetail?> GetOrderDetailByIdAsync(int id)
		{
			var result =  _orderDetailDAO.GetByIdAsync(id);
			return result;
		}

		public async Task<bool> UpdateOrderDetailAsync(OrderDetail orderDetailDAO)
		{
			var result = await _orderDetailDAO.Delete(orderDetailDAO) > 0;
			return result;
		}
	}
}
