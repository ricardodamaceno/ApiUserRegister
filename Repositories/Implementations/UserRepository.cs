using ApiUserRegister.Data;
using ApiUserRegister.Models.Domain;
using ApiUserRegister.Repositories.Interfaces;

namespace ApiUserRegister.Repositories.Implementations
{
	public class UserRepository : IUserRepository
	{
		private readonly AppDbContext _context;

		public UserRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<User> GetUserByUsernameAsync(string username)
		{
			return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
		}

		public async Task AddUserAsync(User user)
		{
			_context.Users.Add(user);
			await _context.SaveChangesAsync();
		}
	}
}
