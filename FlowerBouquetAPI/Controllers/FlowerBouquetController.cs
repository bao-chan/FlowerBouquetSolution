using FlowerBouquetBussinessOject;
using FlowerBouquetBussinessOject.Models;
using FlowerBouquetService;
using FlowerBouquetService.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowerBouquetAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class FlowerBouquetController : ControllerBase
	{
		private readonly IFlowerBouquetService _flowerBouquetService;
		public FlowerBouquetController(IFlowerBouquetService flowerBouquetService)
		{
			_flowerBouquetService = flowerBouquetService;
		}
		[HttpGet("{name}")]
		public IActionResult Search(string name)
		{
			var list = _flowerBouquetService.SearchByName(name);
			return Ok(list);
		}
		
		[HttpGet]
		public IActionResult GetAll()
		{
			var list = _flowerBouquetService.GetAllFlowerBouquetsAsync;
			return Ok(list);
		}
		[HttpGet("{id}")]

		public async Task<IActionResult> GetById(int id)
		{
			try
			{
				var flowerBouquet = _flowerBouquetService.GetFlowerBouquetByIdAsync(id);
				if (flowerBouquet == null)
				{
					return NotFound();
				}
				return Ok(flowerBouquet);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		
		[HttpPost]
		public async Task<IActionResult> CreateFlowerBouquet(FlowerBouquet flowerBouquet)
		{
			try
			{
				var result = _flowerBouquetService.GetFlowerBouquetByIdAsync(flowerBouquet.FlowerBouquetId);
				if (result != null)
				{
					return BadRequest("Create FAIL");
				}
				
				var check = await _flowerBouquetService.CreateFlowerBouquetAsync(flowerBouquet);
				if (check)
				{
					return Ok("Create SUCCESS!");
				}
				return BadRequest("Create FAIL");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpPut("{id}")]

		public async Task<IActionResult> UpdateProfile(FlowerBouquet flowerBouquet)
		{
			try
			{
				var result = _flowerBouquetService.GetFlowerBouquetByIdAsync(flowerBouquet.FlowerBouquetId);
				if (result == null)
				{
					return NotFound();
				}
				var check = await _flowerBouquetService.UpdateFlowerBouquetAsync(flowerBouquet);
				if (check)
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
				bool result = await _flowerBouquetService.DeleteFlowerBouquetAsync(id);
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
