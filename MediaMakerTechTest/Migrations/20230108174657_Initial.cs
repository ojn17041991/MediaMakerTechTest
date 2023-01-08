using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaMakerTechTest.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Additions",
                columns: table => new
                {
                    Input1 = table.Column<double>(type: "float", nullable: false),
                    Input2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Input1 = table.Column<double>(type: "float", nullable: false),
                    Input2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Multiplications",
                columns: table => new
                {
                    Input1 = table.Column<double>(type: "float", nullable: false),
                    Input2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Subtractions",
                columns: table => new
                {
                    Input1 = table.Column<double>(type: "float", nullable: false),
                    Input2 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Additions");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Multiplications");

            migrationBuilder.DropTable(
                name: "Subtractions");
        }
    }
}
