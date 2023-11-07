using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class ItemMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_MainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_OffHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItem_Item_ItemsId",
                table: "InventoryItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Items_MainHandWeaponId",
                table: "Characters",
                column: "MainHandWeaponId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Items_OffHandWeaponId",
                table: "Characters",
                column: "OffHandWeaponId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItem_Items_ItemsId",
                table: "InventoryItem",
                column: "ItemsId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Items_MainHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Items_OffHandWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItem_Items_ItemsId",
                table: "InventoryItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

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
                name: "FK_InventoryItem_Item_ItemsId",
                table: "InventoryItem",
                column: "ItemsId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
