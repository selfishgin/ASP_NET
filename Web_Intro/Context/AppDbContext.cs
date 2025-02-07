using Microsoft.EntityFrameworkCore;
using Web_Intro.Entities;

namespace Web_Intro.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<Customer> Customers { get; set; }
}
