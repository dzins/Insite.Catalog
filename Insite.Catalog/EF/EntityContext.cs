namespace Insite.Catalog.EF
{
	using Insite.Catalog.Entities;
	using Microsoft.EntityFrameworkCore;

	public class EntityContext : DbContext
	{
		//public EntityContext()
		//{
		//}

		public EntityContext(DbContextOptions<EntityContext> options) : base(options)
		{
		}

		public DbSet<Product> Products { get; set; }
	}
}