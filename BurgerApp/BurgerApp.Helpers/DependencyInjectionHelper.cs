using BurgerApp.DataAccess.DataContext;
using BurgerApp.DataAccess.Repositories.Implementations;
using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Services.Implementations;
using BurgerApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BurgerApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services)
        {
            services.AddDbContext<BurgerAppDbContext>(options =>
            options.UseSqlServer(@"Data Source=(localdb)\BurgerAppDb;Database=BurgerAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));
        }

        public static void InjectRepositoriesBurger(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Burger>, BurgerRepository>();
        }

        public static void InjectServicesBurger(this IServiceCollection services)
        {
            services.AddTransient<IBurgerService, BurgerService>();
        }

        public static void InjectRepositoriesOrder(this IServiceCollection services)
        {
            services.AddTransient<IRepository<Order>, OrderRepository>();
        }

        public static void InjectServicesOrder(this IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
        }
    }
}
