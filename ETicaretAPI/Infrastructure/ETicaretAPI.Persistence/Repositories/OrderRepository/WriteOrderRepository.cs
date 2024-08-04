using System;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.OrderRepository
{
	public class WriteOrderRepository : WriteRepository<Order>, IWriteOrderRepository
	{
		public WriteOrderRepository(ETicaretAPIDbContext context) : base(context)
        {
		}
	}
}

