using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Transcendence_Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMigration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ItemId",
                table: "Characters",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Item_ItemId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_ItemId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Characters");
        }
    }
}
