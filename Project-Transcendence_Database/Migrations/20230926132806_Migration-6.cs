using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Agility", "CharacterClassId", "CharacterRaceId", "Expirience", "FinishedDungeonIndex", "Health", "Intelect", "Level", "Luck", "MainHandWeaponId", "Name", "OffHandWeaponId", "Strength", "UserId" },
                values: new object[] { 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 4, "Json", 4, 0, 50 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
