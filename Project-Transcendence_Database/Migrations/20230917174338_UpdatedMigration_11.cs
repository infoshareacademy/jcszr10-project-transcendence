using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMigration_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories",
                column: "PlayerCharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories",
                column: "PlayerCharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
