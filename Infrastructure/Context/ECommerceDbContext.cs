using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
	public class ECommerceDbContext : DbContext
	{
		public ECommerceDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
	}
}
