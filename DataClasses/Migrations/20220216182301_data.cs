using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Classes_WowClassId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Specs_Classes_WowClassId",
                table: "Specs");

            migrationBuilder.DropIndex(
                name: "IX_Specs_WowClassId",
                table: "Specs");

            migrationBuilder.RenameColumn(
                name: "WowClassId",
                table: "Players",
                newName: "WowClassID");

            migrationBuilder.RenameIndex(
                name: "IX_Players_WowClassId",
                table: "Players",
                newName: "IX_Players_WowClassID");

            migrationBuilder.AddColumn<int>(
                name: "SpecId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName", "SpecId" },
                values: new object[,]
                {
                    { 1, "Death Knight", null },
                    { 2, "Demon Hunter", null },
                    { 3, "Druid", null },
                    { 4, "Hunter", null },
                    { 5, "Mage", null },
                    { 6, "Monk", null },
                    { 7, "Paladin", null },
                    { 8, "Priest", null },
                    { 9, "Rogue", null },
                    { 10, "Shaman", null },
                    { 11, "Warlock", null },
                    { 112, "Warrior", null }
                });

            migrationBuilder.InsertData(
                table: "GuildRanks",
                columns: new[] { "Id", "GuildRankName" },
                values: new object[,]
                {
                    { 1, "Guild Master" },
                    { 2, "Officer" },
                    { 3, "Member" },
                    { 4, "Trial" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Tank" },
                    { 2, "Healer" },
                    { 3, "Melee DPS" },
                    { 4, "Ranged DPS" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "TeamName" },
                values: new object[,]
                {
                    { 1, "Mythic Raiding" },
                    { 2, "M+ Team One" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "GuildRankID", "PlayerName", "TeamID", "WowClassID" },
                values: new object[] { 1, 1, "Heterohexual", 1, 10 });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "Id", "RoleId", "SpecName", "WowClassId" },
                values: new object[,]
                {
                    { 1, 1, "Blood", 1 },
                    { 2, 3, "Frost", 1 },
                    { 3, 3, "Blood", 1 },
                    { 4, 1, "Vengeance", 2 },
                    { 5, 3, "Havoc", 2 },
                    { 6, 1, "Guardian", 3 },
                    { 7, 2, "Restoration", 3 },
                    { 8, 3, "Feral", 3 },
                    { 9, 4, "Balance", 3 },
                    { 10, 3, "Survival", 4 },
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
                    { 33, 4, "Affliction", 11 },
                    { 34, 1, "Protection", 12 },
                    { 35, 3, "Fury", 12 },
                    { 36, 3, "Arms", 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SpecId",
                table: "Classes",
                column: "SpecId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Specs_SpecId",
                table: "Classes",
                column: "SpecId",
                principalTable: "Specs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Classes_WowClassID",
                table: "Players",
                column: "WowClassID",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Specs_SpecId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Classes_WowClassID",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Classes_SpecId",
                table: "Classes");

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "GuildRanks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GuildRanks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GuildRanks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specs",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GuildRanks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "SpecId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "WowClassID",
                table: "Players",
                newName: "WowClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_WowClassID",
                table: "Players",
                newName: "IX_Players_WowClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Specs_WowClassId",
                table: "Specs",
                column: "WowClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Classes_WowClassId",
                table: "Players",
                column: "WowClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Specs_Classes_WowClassId",
                table: "Specs",
                column: "WowClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
