using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.ProductRepository
{
	public class ReadProductRepository : ReadRepository<Product>, IReadProductRepository
	{
		public ReadProductRepository(ETicaretAPIDbContext context) : base(context)
        {
		}
	}
}

