using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fall2022_APIWorkshop.Migrations
{
    public partial class addedOneToManyExample : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Studio",
                table: "VideoGames");

            migrationBuilder.AddColumn<int>(
                name: "StudioId",
                table: "VideoGames",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Studios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "EmployeeCount", "Name" },
                values: new object[] { 1, 6717, "Nintendo" });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "EmployeeCount", "Name" },
                values: new object[] { 2, 202, "Hal Laboratories" });

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudioId",
                value: 2);

            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "StudioId", "Title" },
                values: new object[] { 3, 1, "Pikmin" });

            migrationBuilder.InsertData(
                table: "MainCharacters",
                columns: new[] { "Id", "Name", "VideoGameId" },
                values: new object[] { 3, "Captain Olimar", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_VideoGames_StudioId",
                table: "VideoGames",
                column: "StudioId");

            migrationBuilder.AddForeignKey(
                name: "FK_VideoGames_Studios_StudioId",
                table: "VideoGames",
                column: "StudioId",
                principalTable: "Studios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VideoGames_Studios_StudioId",
                table: "VideoGames");

            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropIndex(
                name: "IX_VideoGames_StudioId",
                table: "VideoGames");

            migrationBuilder.DeleteData(
                table: "MainCharacters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "StudioId",
                table: "VideoGames");

            migrationBuilder.AddColumn<string>(
                name: "Studio",
                table: "VideoGames",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "Studio",
                value: "Nintendo");

            migrationBuilder.UpdateData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Studio",
                value: "Hal Laboratories");
        }
    }
}
