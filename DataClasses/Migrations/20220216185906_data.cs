using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName" },
                values: new object[] { 12, "Warrior" });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[,]
                {
                    { 11, 4, "Beast Mastery", 4 },
                    { 12, 4, "Marksmanship", 4 },
                    { 13, 4, "Fire", 5 },
                    { 14, 4, "Frost", 5 },
                    { 15, 4, "Arcane", 5 },
                    { 16, 1, "Brewmaster", 6 },
                    { 17, 2, "Mistweaver", 6 },
                    { 18, 3, "Windwalker", 6 },
                    { 19, 1, "Protection", 7 },
                    { 20, 2, "Holy", 7 },
                    { 21, 3, "Retribution", 7 },
                    { 22, 2, "Discipline", 8 },
                    { 23, 2, "Holy", 8 },
                    { 24, 4, "Shadow", 8 },
                    { 25, 3, "Outlaw", 9 },
                    { 26, 3, "Subtlety", 9 },
                    { 27, 3, "Assassination", 9 },
                    { 28, 2, "Restoration", 10 },
                    { 29, 3, "Enhancement", 10 },
                    { 30, 4, "Elemental", 10 },
                    { 31, 4, "Destruction", 11 },
                    { 32, 4, "Demonology", 11 },
                    { 33, 4, "Affliction", 11 }
                });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 34, 1, "Protection", 12 });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 35, 3, "Fury", 12 });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[] { 36, 3, "Arms", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName" },
                values: new object[] { 112, "Warrior" });
        }
    }
}
