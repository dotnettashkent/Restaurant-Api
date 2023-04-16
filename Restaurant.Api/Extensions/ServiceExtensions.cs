using Restaurant.Data.IRepositories;
using Restaurant.Data.Repositories;
using Restaurant.Service.Interfaces;
using Restaurant.Service.Services;

namespace Restaurant.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IEatRepository, EatRepository>();
            services.AddScoped<IEatService, EatService>();
        }
    }
}
