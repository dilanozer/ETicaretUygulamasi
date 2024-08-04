using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IWriteProductRepository _writeProductRepository;
        readonly private IReadProductRepository _readProductRepository;

        public ProductsController(IWriteProductRepository writeProductRepository, IReadProductRepository readProductRepository)
        {
            _writeProductRepository = writeProductRepository;
            _readProductRepository = readProductRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _writeProductRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10},
                new() {Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20},
                new() {Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 130}
            });

            await _writeProductRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _readProductRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}

