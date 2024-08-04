using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Persistence.Repositories.CustomerRepository;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Persistence.Repositories.OrderRepository;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Persistence.Repositories.ProductRepository;

namespace ETicaretAPI.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
			services.AddScoped<IReadCustomerRepository, ReadCustomerRepository>();
			services.AddScoped<IWriteCustomerRepository, WriteCustomerRepository>();
			services.AddScoped<IReadOrderRepository, ReadOrderRepository>();
			services.AddScoped<IWriteOrderRepository, WriteOrderRepository>();
			services.AddScoped<IReadProductRepository, ReadProductRepository>();
			services.AddScoped<IWriteProductRepository, WriteProductRepository>();
		}
	}
}

