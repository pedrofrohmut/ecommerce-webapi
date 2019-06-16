using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Data.Migrations
{
  public partial class InitialCreate : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Products",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            Title = table.Column<string>(maxLength: 100, nullable: false),
            ImageUrl = table.Column<string>(maxLength: 255, nullable: true),
            Price = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
            Company = table.Column<string>(maxLength: 100, nullable: false),
            Info = table.Column<string>(nullable: true)
          },
          constraints: table => {
            table.PrimaryKey("PK_Products", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Products");
    }
  }
}
