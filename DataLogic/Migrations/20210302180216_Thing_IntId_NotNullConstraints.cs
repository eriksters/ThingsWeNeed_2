using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLogic.Migrations
{
    public partial class Thing_IntId_NotNullConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Things",
                table: "Things");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Things",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Things",
                table: "Things",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Things",
                table: "Things");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Things");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Things",
                table: "Things",
                column: "Name");
        }
    }
}
