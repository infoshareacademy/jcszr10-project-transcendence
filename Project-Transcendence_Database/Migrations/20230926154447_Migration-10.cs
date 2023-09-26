using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "Id", "Level", "Name", "RaceId" },
                values: new object[] { 1, 1, "Andrzej", 4 });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "EnemyId", "PlayerCharacterId" },
                values: new object[] { 3, 1, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
