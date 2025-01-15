using ApiUserRegister.Models.Domain;

namespace ApiUserRegister.Repositories.Interfaces
{
	public interface IUserRepository
	{
		Task<User> GetUserByUsernameAsync(string username);
		Task AddUserAsync(User user);
	}
}
