﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Data.Migrations
{
  [DbContext(typeof(ECommerceDbContext))]
  partial class ECommerceDbContextModelSnapshot : ModelSnapshot
  {
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("Data.Models.Product", b => {
        b.Property<int>("Id")
            .ValueGeneratedOnAdd()
            .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

        b.Property<string>("Company")
            .IsRequired()
            .HasMaxLength(100);

        b.Property<string>("ImageUrl")
            .HasMaxLength(255);

        b.Property<string>("Info");

        b.Property<decimal>("Price")
            .HasColumnType("DECIMAL(18,2)");

        b.Property<string>("Title")
            .IsRequired()
            .HasMaxLength(100);

        b.HasKey("Id");

        b.ToTable("Products");
      });
#pragma warning restore 612, 618
    }
  }
}
