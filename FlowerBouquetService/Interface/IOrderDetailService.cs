﻿using FlowerBouquetBussinessOject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerBouquetService.Interface
{
	public interface IOrderDetailService
	{
		Task<IEnumerable<OrderDetail>> GetAllOrderDetailsAsync();

		Task<OrderDetail?> GetOrderDetailByIdAsync(int orderDetailId);

		Task<bool> CreateOrderDetailAsync(OrderDetail OrderDetail);

		Task<bool> UpdateOrderDetailAsync(OrderDetail OrderDetail);

		Task<bool> DeleteOrderDetailAsync(int orderDetailId);
	}
}
