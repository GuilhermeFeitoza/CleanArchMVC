using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Caderno espiral','100 folhas',7.45,50,'caderno1.jpg',1)");
            migrationBuilder.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
             "VALUES('Lapiseira','0.7',7.45,50,'lapiseira.jpg',1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
