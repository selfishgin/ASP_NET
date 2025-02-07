using Web_Intro.CustomerDTOs;
using Web_Intro.Entities;
using Web_Intro.Repositories;

namespace Web_Intro.Services;

public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
{
	private readonly ICustomerRepository _customerRepository = customerRepository;

	public Customer Add(AddDto customer)
	{
		Customer newCustomer = new() { CustomerId = customer.CustomerId, CompanyName=customer.CompanyName };
		_customerRepository.Add(newCustomer);

		return newCustomer;
	}

	public bool Delete(string id)
	{
		_customerRepository.Delete(id);
		return true;
	}

	public List<Customer> GetAll()
	{
		var list = _customerRepository.GetAll();
		return [.. list];
	}

	public Customer GetById(string id)
	{
		var result = _customerRepository.GetById(id);
		return result;
	}

	public bool Update(Customer customer)
	{
		_customerRepository.Update(customer);
		return true;
	}
}
