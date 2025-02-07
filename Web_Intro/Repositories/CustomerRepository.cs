using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Web_Intro.Context;
using Web_Intro.Entities;

namespace Web_Intro.Repositories;

public class CustomerRepository(AppDbContext dbContext) : ICustomerRepository
{
	private readonly AppDbContext _dbContext = dbContext;



	public void Add(Customer customer)
	{
		_dbContext.Add(customer);
		_dbContext.SaveChanges();
	}

	public void Delete(string id)
	{
		var current = _dbContext.Customers.FirstOrDefault(x => x.CustomerId == id);
		if (current != null)
		{
			_dbContext.Remove(current);
			_dbContext.SaveChanges();
		}
	}

	public IQueryable<Customer> GetAll()
	{
		return _dbContext.Customers;
	}

	public Customer GetById(string id)
	{
		var current = _dbContext.Customers.FirstOrDefault(u => u.CustomerId == id);
		return current;
	}

	public void Update(Customer customer)
	{
		_dbContext.Update(customer);
		_dbContext.SaveChanges();
	}
}
