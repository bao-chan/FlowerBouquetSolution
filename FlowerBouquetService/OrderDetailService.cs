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
	public class OrderDetailService : IOrderDetailService
	{
		private readonly IOrderDetailRepo _orderDetailRepo;
		public OrderDetailService(IOrderDetailRepo orderDetailRepo)
		{
			_orderDetailRepo = orderDetailRepo;
		}

		public async Task<bool> CreateOrderDetailAsync(OrderDetail OrderDetail)
		{
			return await _orderDetailRepo.CreateOrderDetailAsync(OrderDetail);
		}

		public async Task<bool> DeleteOrderDetailAsync(int orderDetailId)
		{
			return await _orderDetailRepo.DeleteOrderDetailAsync(orderDetailId);
		}

		public async Task<IEnumerable<OrderDetail>> GetAllOrderDetailsAsync()
		{
			return await _orderDetailRepo.GetAllOrderDetailsAsync();
		}

		public async Task<OrderDetail?> GetOrderDetailByIdAsync(int orderDetailId)
		{
			return await _orderDetailRepo.GetOrderDetailByIdAsync(orderDetailId);
		}

		public async Task<bool> UpdateOrderDetailAsync(OrderDetail OrderDetail)
		{
			return await _orderDetailRepo.UpdateOrderDetailAsync(OrderDetail);
		}
	}
}
