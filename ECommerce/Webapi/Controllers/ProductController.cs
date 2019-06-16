using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly ECommerceDbContext _context;

    public ProductController(ECommerceDbContext context)
    {
      _context = context;
    }

    // GET api/product
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
      return Ok(await _context.Products.ToListAsync());
    }

    // GET api/product/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
      var product = await _context.Products
        .SingleOrDefaultAsync(_product => _product.Id == id);

      if (product == null) {
        return BadRequest("No Product Found With the id informed.");
      }

      return Ok(product);    
    }
  } 
}
