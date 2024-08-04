using System;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.CustomerRepository
{
	public class WriteCustomerRepository : WriteRepository<Customer>, IWriteCustomerRepository
	{
		public WriteCustomerRepository(ETicaretAPIDbContext context) : base(context)
		{
		}
	}
}

