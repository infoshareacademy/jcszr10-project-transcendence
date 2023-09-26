using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Health",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Opis umiejętności mnicha 1");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Opis umiejętności mnicha 2");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Opis umiejętności mnicha 3");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Opis umiejętności mnicha 4");

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CharacterClassId", "ClassType", "Damage", "Description", "Healing", "Name", "ResourceCost" },
                values: new object[,]
                {
                    { 5, 2, 1, 10, "Opis umiejętności czarodzieja 1", 0, "Umiejętność 1", 2 },
                    { 6, 2, 1, 15, "Opis umiejętności czarodzieja 2", 0, "Umiejętność 2", 1 },
                    { 7, 2, 1, 15, "Opis umiejętności czarodzieja 3", 0, "Umiejętność 3", 1 },
                    { 8, 2, 1, 15, "Opis umiejętności czarodzieja 4", 0, "Umiejętność 4", 1 },
                    { 9, 3, 3, 10, "Opis umiejętności łotrzyka 1", 0, "Umiejętność 1", 2 },
                    { 10, 3, 3, 15, "Opis umiejętności łotrzyka 2", 0, "Umiejętność 2", 1 },
                    { 11, 3, 3, 15, "Opis umiejętności łotrzyka 3", 0, "Umiejętność 3", 1 },
                    { 12, 3, 3, 15, "Opis umiejętności łotrzyka 4", 0, "Umiejętność 4", 1 },
                    { 13, 4, 2, 10, "Opis umiejętności wojownika 1", 0, "Umiejętność 1", 2 },
                    { 14, 4, 2, 15, "Opis umiejętności wojownika 2", 0, "Umiejętność 2", 1 },
                    { 15, 4, 2, 15, "Opis umiejętności wojownika 3", 0, "Umiejętność 3", 1 },
                    { 16, 4, 2, 15, "Opis umiejętności wojownika 4", 0, "Umiejętność 4", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Login", "Password" },
                values: new object[] { 50, "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "Health",
                table: "Characters");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Opis umiejętności 1");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Opis umiejętności 2");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Opis umiejętności 3");

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Opis umiejętności 4");
        }
    }
}
