using FlowerBouquetBussinessOject.Models;
using FlowerBouquetService.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace FlowerBouquetAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private IConfiguration _configuration;
		private readonly ICustomerService _customerService;
		public AuthController(IConfiguration configuration, ICustomerService customerService)
		{
			_configuration = configuration;
			_customerService = customerService;
		}

		[AllowAnonymous]
		[HttpPost]
		public IActionResult Login(string email, string password) 
		{
			IActionResult result = Unauthorized();
			var customer = _customerService.LoginByEmailAndPassword(email, password);
			if(customer != null) {
				var tokenString = GenerateJSONWebToken(customer);
				result = Ok(new {token = tokenString});
			}
			return result;
		}
		private string GenerateJSONWebToken(Customer customer)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
			var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(_configuration["Jwt:Issuer"],
			  _configuration["Jwt:Issuer"],
			  null,
			  expires: DateTime.Now.AddMinutes(120),
			  signingCredentials: credentials);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
