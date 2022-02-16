using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[,]
                {
                    { 7, 2, "Restoration", 3 },
                    { 8, 3, "Feral", 3 },
                    { 9, 4, "Balance", 3 },
                    { 10, 3, "Survival", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
