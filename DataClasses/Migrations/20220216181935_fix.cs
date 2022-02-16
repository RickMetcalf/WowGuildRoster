using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLibrary.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Players_PlayerId",
                table: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Classes_PlayerId",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Classes");

            migrationBuilder.RenameColumn(
                name: "PlayerClassID",
                table: "Players",
                newName: "WowClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_WowClassId",
                table: "Players",
                column: "WowClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Classes_WowClassId",
                table: "Players",
                column: "WowClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Classes_WowClassId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_WowClassId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "WowClassId",
                table: "Players",
                newName: "PlayerClassID");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classes_PlayerId",
                table: "Classes",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Players_PlayerId",
                table: "Classes",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id");
        }
    }
}
