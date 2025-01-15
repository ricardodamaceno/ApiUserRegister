using ApiUserRegister.Repositories.Implementations;
using ApiUserRegister.Repositories.Interfaces;
using ApiUserRegister.Services.Implementations;
using ApiUserRegister.Services.Interfaces;

namespace ApiUserRegister.DependencyInjection
{
	public static class DependencyInjectionConfig
	{
		public static void RegisterServices(IServiceCollection services)
		{
			// Repositories
			services.AddScoped<IUserRepository, UserRepository>();

			// Services
			services.AddScoped<IUserService, UserService>();
		}
	}
}
