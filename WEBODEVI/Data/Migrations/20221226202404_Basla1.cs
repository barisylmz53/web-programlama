using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBODEVI.Data.Migrations
{
    public partial class Basla1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarHourPrice = table.Column<int>(type: "int", nullable: false),
                    CarDayPrice = table.Column<int>(type: "int", nullable: false),
                    CarMonthPrice = table.Column<int>(type: "int", nullable: false),
                    CarPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
