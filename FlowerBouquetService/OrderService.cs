using FlowerBouquetBussinessOject.Models;
using FlowerBouquetRepository;
using FlowerBouquetRepository.InterFace;
using FlowerBouquetService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetService
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepo _orderRepo;
		public OrderService(IOrderRepo orderRepo) { _orderRepo = orderRepo; }
		public async Task<bool> CreateOrderAsync(Order Order)
		{
			return await _orderRepo.CreateOrderAsync(Order);
		}

		public async Task<bool> DeleteOrderAsync(int orderId)
		{
			return await _orderRepo.DeleteOrderAsync(orderId);
		}

		public async Task<IEnumerable<Order>> GetAllOrdersAsync()
		{
			return await _orderRepo.GetAllOrdersAsync();
		}

		public async Task<Order?> GetOrderByIdAsync(int orderId)
		{
			return await _orderRepo.GetOrderByIdAsync(orderId);
		}

		public async Task<bool> UpdateOrderAsync(Order Order)
		{
			return await _orderRepo.UpdateOrderAsync(Order);
		}
	}
}
