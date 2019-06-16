using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Data
{
  public static class SeedData
  {
    private static Product[] products = new Product[]
    {
      new Product
      {
        Title = "Google Pixel - Black",
        ImageUrl = "img/product-1.png",
        Price = 1992.10M,
        Company = "Google",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "Samsung S7",
        ImageUrl = "img/product-2.png",
        Price = 1599.99M,
        Company = "Samsung",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "HTC 10 - Black",
        ImageUrl = "img/product-3.png",
        Price = 693.63M,
        Company = "HTC",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "HTC 10 - White",
        ImageUrl = "img/product-4.png",
        Price = 584.53M,
        Company = "HTC",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "HTC Desire 626s",
        ImageUrl = "img/product-5.png",
        Price = 792.08M,
        Company = "HTC",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "Vintage Iphone",
        ImageUrl = "img/product-6.png",
        Price = 1947.35M,
        Company = "Apple",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "Iphone 7",
        ImageUrl = "img/product-7.png",
        Price = 2464.15M,
        Company = "Apple",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      },
      new Product
      {
        Title = "Smashed Iphone",
        ImageUrl = "img/product-8.png",
        Price = 55.37M,
        Company = "Apple",
        Info = "Lorem ipsum dolor amet offal butcher quinoa sustainable gastropub, echo park actually green juice sriracha paleo. Brooklyn sriracha semiotics, DIY coloring book mixtape craft beer sartorial hella blue bottle. Tote bag wolf authentic try-hard put a bird on it mumblecore. Unicorn lumbersexual master cleanse blog hella VHS, vaporware sartorial church-key cardigan single-origin coffee lo-fi organic asymmetrical. Taxidermy semiotics celiac stumptown scenester normcore, ethical helvetica photo booth gentrify."
      }
    };

    public static void Initialize(IServiceProvider serviceProvider)
    {
      var requiredService = serviceProvider
        .GetRequiredService<DbContextOptions<ECommerceDbContext>>();

      using (var ctx = new ECommerceDbContext(requiredService)) {
        if (ctx.Products.Any()) {
          return;
        }

        ctx.Products.AddRange(products);
        ctx.SaveChanges();
      }
    }
  }
}
