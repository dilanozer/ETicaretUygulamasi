using System;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.ProductRepository
{
	public class WriteProductRepository : WriteRepository<Product>, IWriteProductRepository
	{
		public WriteProductRepository(ETicaretAPIDbContext context) : base(context)
        {
		}
	}
}

