using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBODEVI.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    UyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeSoyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.UyeID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uyeler");
        }
    }
}
