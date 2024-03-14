using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetRepository.InterFace
{
	public interface IOrderDetailRepo
	{
		Task<IEnumerable<OrderDetail>> GetAllOrderDetailsAsync();

		Task<OrderDetail?> GetOrderDetailByIdAsync(int orderId);

		Task<bool> CreateOrderDetailAsync(OrderDetail Order);

		Task<bool> UpdateOrderDetailAsync(OrderDetail Order);

		Task<bool> DeleteOrderDetailAsync(int orderId);
	}
}
