using Web_Intro.CustomerDTOs;
using Web_Intro.Entities;

namespace Web_Intro.Services;

public interface ICustomerService
{
	Customer Add(AddDto customer);
	bool Update(Customer customer);
	List<Customer> GetAll();
	Customer GetById(string id);
	bool Delete(string id);
}
