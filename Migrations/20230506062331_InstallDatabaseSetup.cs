using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesCRMApp.Migrations
{
    /// <inheritdoc />
    public partial class InstallDatabaseSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesLead",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesLead", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesLead");
        }
    }
}
