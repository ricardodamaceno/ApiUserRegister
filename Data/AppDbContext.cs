using ApiUserRegister.Models.Domain;
using System.Collections.Generic;

namespace ApiUserRegister.Data
{
	public class AppDbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
	}
}
