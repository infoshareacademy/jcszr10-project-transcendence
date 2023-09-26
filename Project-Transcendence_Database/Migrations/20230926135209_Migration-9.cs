using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InventoryItem",
                columns: new[] { "InventoriesId", "ItemsId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 10 },
                    { 2, 11 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "InventoryItem",
                keyColumns: new[] { "InventoriesId", "ItemsId" },
                keyValues: new object[] { 2, 11 });
        }
    }
}
