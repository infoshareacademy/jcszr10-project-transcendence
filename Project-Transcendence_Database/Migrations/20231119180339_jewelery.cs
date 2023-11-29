using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class jewelery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EquipedJeweleries_ItemId",
                table: "EquipedJeweleries",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_EquipedJeweleries_Items_ItemId",
                table: "EquipedJeweleries",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EquipedJeweleries_Items_ItemId",
                table: "EquipedJeweleries");

            migrationBuilder.DropIndex(
                name: "IX_EquipedJeweleries_ItemId",
                table: "EquipedJeweleries");
        }
    }
}
