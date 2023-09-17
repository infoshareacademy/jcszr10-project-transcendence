using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMigration_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_MainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_OffHandWeaponId",
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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_MainHandWeaponId",
                table: "Characters",
                column: "MainHandWeaponId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_OffHandWeaponId",
                table: "Characters",
                column: "OffHandWeaponId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories",
                column: "PlayerCharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_MainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_OffHandWeaponId",
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
                name: "FK_Characters_Item_MainHandWeaponId",
                table: "Characters",
                column: "MainHandWeaponId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_OffHandWeaponId",
                table: "Characters",
                column: "OffHandWeaponId",
                principalTable: "Item",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Characters_PlayerCharacterId",
                table: "Inventories",
                column: "PlayerCharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
