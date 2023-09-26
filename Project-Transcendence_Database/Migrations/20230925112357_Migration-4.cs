using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Naszyjnik imbued z magią, zwiększa siłę o 5");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Perła o magicznym pochodzeniu, zwiększa inteligencję o 4");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Elegancka bransoletka, zwiększa zręczność o 3");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Tajemniczy pierścień, który przynosi szczęście, zwiększa szczęście o 2");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Amulet odwagi, który zwiększa siłę o 3 i zręczność o 2");

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "Id", "Amount", "MaxAmount", "Name" },
                values: new object[,]
                {
                    { 1, 100, 100, "Energia" },
                    { 2, 100, 100, "Gniew" },
                    { 3, 100, 100, "Mana" },
                    { 4, 10, 10, "Chi" }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "Name", "PlayerCharacterId", "ResourceId" },
                values: new object[,]
                {
                    { 1, "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", "Mnich", 0, 4 },
                    { 2, "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", "Czarodziej", 0, 3 },
                    { 3, "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", "Łotrzyk", 0, 1 },
                    { 4, "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", "Wojownik", 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "Id", "CharacterClassId", "ClassType", "Damage", "Description", "Healing", "Name", "ResourceCost" },
                values: new object[,]
                {
                    { 1, 1, 0, 10, "Opis umiejętności 1", 0, "Umiejętność 1", 2 },
                    { 2, 1, 0, 15, "Opis umiejętności 2", 0, "Umiejętność 2", 1 },
                    { 3, 1, 0, 15, "Opis umiejętności 3", 0, "Umiejętność 3", 1 },
                    { 4, 1, 0, 15, "Opis umiejętności 4", 0, "Umiejętność 4", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Naszyjnik imbued z magią, zwiększa siłę o 5.");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Perła o magicznym pochodzeniu, zwiększa inteligencję o 4.");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Elegancka bransoletka, zwiększa zręczność o 3.");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Tajemniczy pierścień, który przynosi szczęście, zwiększa szczęście o 2.");

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Amulet odwagi, który zwiększa siłę o 3 i zręczność o 2.");
        }
    }
}
