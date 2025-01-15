namespace ApiUserRegister.Services.Interfaces
{
	public interface IUserService
	{
		Task<bool> RegisterAsync(string username, string password);
		Task<bool> LoginAsync(string username, string password);
	}
}
