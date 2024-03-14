using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository.InterFace
{
	public interface IOrderRepo
	{
		Task<IEnumerable<Order>> GetAllOrdersAsync();

		Task<Order?> GetOrderByIdAsync(int orderId);

		Task<bool> CreateOrderAsync(Order Order);

		Task<bool> UpdateOrderAsync(Order Order);

		Task<bool> DeleteOrderAsync(int orderId);
	}
}
