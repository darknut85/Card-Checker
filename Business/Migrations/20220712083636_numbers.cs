using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class numbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnedCards",
                table: "Sets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalCards",
                table: "Sets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OwnedCards", "TotalCards" },
                values: new object[] { 1, 126 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnedCards",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "TotalCards",
                table: "Sets");
        }
    }
}
