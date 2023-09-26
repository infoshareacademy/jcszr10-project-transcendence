using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedItemsAndRacesfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "Agility", "Armor", "Damage", "Description", "Healing", "Intelect", "ItemType", "Luck", "Name", "Strength" },
                values: new object[,]
                {
                    { 1, null, null, 10, "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", null, null, 0, null, "Zwykły stalowy miecz", null },
                    { 2, null, null, 7, "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", null, null, 0, null, "Zwykły stalowy sztylet", null },
                    { 3, null, null, 5, "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", null, null, 0, null, "Zwykłe rękawice mnicha bojowego", null },
                    { 4, null, null, 5, "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", null, null, 0, null, "Zwykły dębowy kostur", null },
                    { 5, null, null, null, "Srebrny pierścień zaklęty przez kowala tak by zwiększał sczęście o 1", null, null, 1, 2, "Zwykły pierścień szczęścia", null },
                    { 6, 2, null, null, "Srebrny pierścień zaklęty przez kowala tak by zwiększał zręczność o 1", null, null, 1, null, "Zwykły pierścień zręczności", null },
                    { 7, null, null, null, "Srebrny pierścień zaklęty przez kowala tak by zwiększał siłę o 1", null, null, 1, null, "Zwykły pierścień siły", 2 },
                    { 8, null, null, null, "Srebrny pierścień zaklęty przez kowala tak by zwiększać inteligencję o 1", null, 2, 1, null, "Zwykły pierścień inteligencji", null },
                    { 9, 1, null, null, "Srebrny pierścień zaklęty przez kowala tak by zwiększać wszystkie statystyki o 1 ", null, 1, 1, 1, "Magiczny pierścień", 1 },
                    { 10, null, null, null, "TzewohTts elcpamw eiltr hnu'semoy", null, null, 1, 100, "Pierścień Boga", null },
                    { 11, null, null, 8, "Elegancki srebrny sztylet, idealny do skrytych ataków.", null, null, 0, null, "Srebrny sztylet", null },
                    { 12, null, null, 12, "Drewniany łuk dębowy z zestawem strzał.", null, null, 0, null, "Łuk dębowy", null },
                    { 13, null, null, 15, "Ciężki topór bojowy z masywnym ostrzem.", null, null, 0, null, "Topór bojowy", null },
                    { 14, null, null, 5, "Różdżka wykonana z jesionu, zdolna do rzucania potężnych zaklęć.", null, null, 0, null, "Magiczny różdżka", null },
                    { 15, null, null, null, "Naszyjnik imbued z magią, zwiększa siłę o 5.", null, null, 1, null, "Naszyjnik mocy", 5 },
                    { 16, null, null, null, "Perła o magicznym pochodzeniu, zwiększa inteligencję o 4.", null, 4, 1, null, "Perła mądrości", null },
                    { 17, 3, null, null, "Elegancka bransoletka, zwiększa zręczność o 3.", null, null, 1, null, "Bransoletka zręczności", null },
                    { 18, null, null, null, "Tajemniczy pierścień, który przynosi szczęście, zwiększa szczęście o 2.", null, null, 1, 2, "Pierścień szczęścia", null },
                    { 19, 2, null, null, "Amulet odwagi, który zwiększa siłę o 3 i zręczność o 2.", null, null, 1, null, "Amulet odwagi", 3 }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Zróżnicowana i wszechstronna rasa ludzi.", "Człowiek" },
                    { 2, "Elegancka i długo żyjąca rasa elfów.", "Elf" },
                    { 3, "Silni i wytrwali krasnoludy znane ze swojego rzemiosła.", "Krasnolud" },
                    { 4, "Groźni wojownicy orkowie znani ze swojej siły.", "Ork" },
                    { 5, "Małe i zwinne niziołki, mistrzowie kamuflażu.", "Niziołek" },
                    { 6, "Strażnicy lasów, związani z naturą.", "Driad" },
                    { 7, "Małe wynalazcze gnomowie, znawcy technologii.", "Gnom" },
                    { 8, "Potomkowie ludzi i istot boskich, posiadający boskie dziedzictwo.", "Aasimar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
