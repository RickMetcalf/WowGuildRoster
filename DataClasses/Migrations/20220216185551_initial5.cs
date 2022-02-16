using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 4, 1, "Vengeance", 2 });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 5, 3, "Havoc", 2 });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 6, 1, "Guardian", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
