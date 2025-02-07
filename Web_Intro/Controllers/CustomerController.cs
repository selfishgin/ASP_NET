using Microsoft.AspNetCore.Mvc;
using Web_Intro.CustomerDTOs;
using Web_Intro.Entities;
using Web_Intro.Services;

namespace Web_Intro.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController(ICustomerService customerService) : ControllerBase
{
	private readonly ICustomerService _customerService = customerService;

	[HttpPost]
	public IActionResult AddCustomer(AddDto customer)
	{
		var newCustomer = _customerService.Add(customer);
		return Ok(newCustomer);
	}


	[HttpGet]

	public IActionResult GetAllCustomer()
	{
		var list = _customerService.GetAll();
		return Ok(list.ToList());
	}


	[HttpGet("{id}")]
	public IActionResult GetById(string id)
	{
		var currentCustomer = _customerService.GetById(id);
		return Ok(currentCustomer);
	}


	[HttpDelete("{id}")]
	public IActionResult Delete(string id) 
	{
		var isDeleted = _customerService.Delete(id);
		return Ok(isDeleted);
	
	}

}
