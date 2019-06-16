﻿using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
  public class ECommerceDbContext : DbContext
  {
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
      : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
  }
}
