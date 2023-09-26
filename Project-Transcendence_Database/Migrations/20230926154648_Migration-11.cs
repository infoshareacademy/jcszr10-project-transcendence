using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.InsertData(
                table: "InventoryItem",
                columns: new[] { "InventoriesId", "ItemsId" },
                values: new object[,]
                {
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 14 },
                    { 3, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 3, 10 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.InsertData(
                table: "InventoryItem",
                columns: new[] { "InventoriesId", "ItemsId" },
                values: new object[] { 2, 10 });
        }
    }
}
