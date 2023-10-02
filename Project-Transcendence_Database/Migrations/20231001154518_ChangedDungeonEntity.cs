using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDungeonEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PuzzleDungeons");

            migrationBuilder.DropTable(
                name: "ShopDungeons");

            migrationBuilder.AlterColumn<int>(
                name: "DungeonType",
                table: "EnemyDungeons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DungeonType",
                table: "EnemyDungeons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "PuzzleDungeons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungeonLevel = table.Column<int>(type: "int", nullable: false),
                    DungeonStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungeonType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuzzleDungeons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopDungeons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungeonLevel = table.Column<int>(type: "int", nullable: false),
                    DungeonStory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DungeonType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopDungeons", x => x.Id);
                });
        }
    }
}
