using System;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.CustomerRepository
{
	public class ReadCustomerRepository : ReadRepository<Customer>, IReadCustomerRepository
	{
		public ReadCustomerRepository(ETicaretAPIDbContext context) : base(context)
		{

		}
	}
}

