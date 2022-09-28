using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fall2022_APIWorkshop.Migrations
{
    public partial class addedOneToOneRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainCharacter",
                table: "VideoGames");

            migrationBuilder.CreateTable(
                name: "MainCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCharacters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainCharacters_VideoGames_VideoGameId",
                        column: x => x.VideoGameId,
                        principalTable: "VideoGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MainCharacters",
                columns: new[] { "Id", "Name", "VideoGameId" },
                values: new object[] { 1, "Mario", 1 });

            migrationBuilder.InsertData(
                table: "MainCharacters",
                columns: new[] { "Id", "Name", "VideoGameId" },
                values: new object[] { 2, "Kirby", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_MainCharacters_VideoGameId",
                table: "MainCharacters",
                column: "VideoGameId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainCharacters");

            migrationBuilder.AddColumn<string>(
                name: "MainCharacter",
                table: "VideoGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainCharacter",
                value: "Mario");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainCharacter",
                value: "Kirby");
        }
    }
}
