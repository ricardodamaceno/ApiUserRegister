using ApiUserRegister.Models.Domain;
using ApiUserRegister.Repositories.Interfaces;
using ApiUserRegister.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace ApiUserRegister.Services.Implementations
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _repository;

		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}

		public async Task<bool> RegisterAsync(string username, string password)
		{
			if (await _repository.GetUserByUsernameAsync(username) != null)
				return false; // Username already exists

			var salt = GenerateSalt();
			var hash = HashPassword(password, salt);

			var user = new User
			{
				Username = username,
				PasswordHash = hash,
				Salt = salt
			};

			await _repository.AddUserAsync(user);
			return true;
		}

		public async Task<bool> LoginAsync(string username, string password)
		{
			var user = await _repository.GetUserByUsernameAsync(username);
			if (user == null) return false;

			var hash = HashPassword(password, user.Salt);
			return hash == user.PasswordHash;
		}

		private string GenerateSalt()
		{
			var buffer = new byte[16];
			using var rng = RandomNumberGenerator.Create();
			rng.GetBytes(buffer);
			return Convert.ToBase64String(buffer);
		}

		private string HashPassword(string password, string salt)
		{
			using var sha256 = SHA256.Create();
			var combined = Encoding.UTF8.GetBytes(password + salt);
			return Convert.ToBase64String(sha256.ComputeHash(combined));
		}
	}
}
