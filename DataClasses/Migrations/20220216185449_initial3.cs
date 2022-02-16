using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 2, 3, "Frost", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
