using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogic.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Things",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Needed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Things");
        }
    }
}
