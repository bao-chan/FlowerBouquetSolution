using FlowerBouquetBussinessOject;
using FlowerBouquetBussinessOject.Models;
using FlowerBouquetService.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace FlowerBouquetAPI.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;
		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		
		[HttpGet]
		
		public IActionResult GetAllCustumer()
		{
			try
			{
				var list = _customerService.GetAllCustomerAsync();
				if (list == null)
				{
					return BadRequest("List is null");
				}
				return Ok(list);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpGet("{id}")]
		
		public async Task<IActionResult> GetCustomerById(int id)
		{
			try
			{
				var customer = _customerService.GetCustomerByIdAsync(id);
				if (customer == null)
				{
					return NotFound();
				}
				return Ok(customer);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpPut("{id}")]
		
		public async Task<IActionResult> UpdateProfile(Customer customer)
		{
			try
			{
				var cutomer = _customerService.GetCustomerByIdAsync(customer.CustomerId);
				if (customer == null)
				{
					return NotFound();
				}
				var result = await _customerService.UpdateCustomerAsync(customer);
				if (result)
				{
					return Ok("Update SUCCESS!");
				}
				return BadRequest("Update FAIL");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}
		[HttpDelete("{id}")]
		
		public async Task<IActionResult> DeleteCustomer(int id)
		{
			try
			{
				bool result = await _customerService.DeleteCustomerAsync(id);
				if (!result)
				{
					return BadRequest("Delete Fail");
				}
				return Ok("Delete Success");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
