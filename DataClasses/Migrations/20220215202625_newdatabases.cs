using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class newdatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlayerClass",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Players",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Players",
                newName: "RoleID");

            migrationBuilder.RenameColumn(
                name: "AltRoleId",
                table: "Players",
                newName: "AltRoleID");

            migrationBuilder.AddColumn<int>(
                name: "PlayerClassID",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecializationID",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassID);
                });

            migrationBuilder.CreateTable(
                name: "GuildRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuildRankName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuildRanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Specs",
                columns: table => new
                {
                    SpecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specs", x => x.SpecID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MaxTeamSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "ClassID", "ClassName" },
                values: new object[,]
                {
                    { 1, "Death Knight" },
                    { 2, "Demon Hunter" },
                    { 3, "Druid" },
                    { 4, "Hunter" },
                    { 5, "Mage" },
                    { 6, "Monk" },
                    { 7, "Paladin" },
                    { 8, "Priest" },
                    { 9, "Rogue" },
                    { 10, "Shaman" },
                    { 11, "Warlock" },
                    { 112, "Warrior" }
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
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Tank" },
                    { 2, "Healer" },
                    { 3, "Melee DPS" },
                    { 4, "Ranged DPS" }
                });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "SpecID", "ClassID", "RoleID", "SpecName" },
                values: new object[,]
                {
                    { 1, 1, 1, "Blood" },
                    { 2, 1, 3, "Frost" },
                    { 3, 1, 3, "Blood" },
                    { 4, 2, 1, "Vengeance" },
                    { 5, 2, 3, "Havoc" },
                    { 6, 3, 1, "Guardian" },
                    { 7, 3, 2, "Restoration" },
                    { 8, 3, 3, "Feral" },
                    { 9, 3, 4, "Balance" },
                    { 10, 4, 3, "Survival" },
                    { 11, 4, 4, "Beast Mastery" },
                    { 12, 4, 4, "Marksmanship" },
                    { 13, 5, 4, "Fire" },
                    { 14, 5, 4, "Frost" },
                    { 15, 5, 4, "Arcane" },
                    { 16, 6, 1, "Brewmaster" },
                    { 17, 6, 2, "Mistweaver" },
                    { 18, 6, 3, "Windwalker" },
                    { 19, 7, 1, "Protection" },
                    { 20, 7, 2, "Holy" },
                    { 21, 7, 3, "Retribution" },
                    { 22, 8, 2, "Discipline" }
                });

            migrationBuilder.InsertData(
                table: "Specs",
                columns: new[] { "SpecID", "ClassID", "RoleID", "SpecName" },
                values: new object[,]
                {
                    { 23, 8, 2, "Holy" },
                    { 24, 8, 4, "Shadow" },
                    { 25, 9, 3, "Outlaw" },
                    { 26, 9, 3, "Subtlety" },
                    { 27, 9, 3, "Assassination" },
                    { 28, 10, 2, "Restoration" },
                    { 29, 10, 3, "Enhancement" },
                    { 30, 10, 4, "Elemental" },
                    { 31, 11, 4, "Destruction" },
                    { 32, 11, 4, "Demonology" },
                    { 33, 11, 4, "Affliction" },
                    { 34, 12, 1, "Protection" },
                    { 35, 12, 3, "Fury" },
                    { 36, 12, 3, "Arms" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "GuildRanks");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Specs");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropColumn(
                name: "PlayerClassID",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "SpecializationID",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Players",
                newName: "TeamId");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "Players",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "AltRoleID",
                table: "Players",
                newName: "AltRoleId");

            migrationBuilder.AddColumn<string>(
                name: "PlayerClass",
                table: "Players",
                type: "nvarchar(16)",
                maxLength: 16,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Players",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");
        }
    }
}
