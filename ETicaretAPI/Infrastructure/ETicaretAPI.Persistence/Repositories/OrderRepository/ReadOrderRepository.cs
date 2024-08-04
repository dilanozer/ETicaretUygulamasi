using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.OrderRepository
{ 
	public class ReadOrderRepository : ReadRepository<Order>, IReadOrderRepository
	{
		public ReadOrderRepository(ETicaretAPIDbContext context) : base(context)
        {
		}
	}
}

