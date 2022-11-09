using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessPlayerAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChessPlayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ELO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChessPlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChessplayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Records_ChessPlayers_ChessplayerId",
                        column: x => x.ChessplayerId,
                        principalTable: "ChessPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChessplayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Titles_ChessPlayers_ChessplayerId",
                        column: x => x.ChessplayerId,
                        principalTable: "ChessPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ChessPlayers",
                columns: new[] { "Id", "ELO", "Name", "Nationality" },
                values: new object[] { new Guid("1f5e8297-d50f-4151-a669-844425774a18"), 2747, "Karjakin", "Russia" });

            migrationBuilder.InsertData(
                table: "ChessPlayers",
                columns: new[] { "Id", "ELO", "Name", "Nationality" },
                values: new object[] { new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"), 2859, "Carlson", "Norway" });

            migrationBuilder.InsertData(
                table: "ChessPlayers",
                columns: new[] { "Id", "ELO", "Name", "Nationality" },
                values: new object[] { new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"), 2766, "Caruana", "USA" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "ChessplayerId", "Name" },
                values: new object[,]
                {
                    { new Guid("01b4c394-cfe7-473e-99c8-7f4ae39654f0"), new Guid("1f5e8297-d50f-4151-a669-844425774a18"), "Youngest International Master Ever" },
                    { new Guid("0ad4d821-2455-49e6-bcad-7bce983a3097"), new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"), "Highest ELO ever achieved " },
                    { new Guid("0ddf44be-403f-4645-93db-0f7a58bc35ce"), new Guid("1f5e8297-d50f-4151-a669-844425774a18"), "Youngest Grand Master Ever" },
                    { new Guid("a8818418-d52d-4ea7-8390-97f9aaabd6b0"), new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"), "Longest unbeaten steak at elite level (125 games)" },
                    { new Guid("b0bb7e69-0b83-4d1e-8af8-4945ddae1123"), new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"), "Highest performance rating in an elite level tournament (3098 ELO)" }
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "ChessplayerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0fb06218-e11b-4b0c-9ad3-2bb5e09ae0b9"), new Guid("1f5e8297-d50f-4151-a669-844425774a18"), "World Rapid Champion 2012" },
                    { new Guid("10ffc982-1807-4979-b1d2-5f5622b3a683"), new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"), "World Chess Champion" },
                    { new Guid("90316a96-a678-49bd-a471-e9cd8c56bb72"), new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"), "World Rapid Chess Champion" },
                    { new Guid("c7befc86-a065-41d7-8777-420aea641d13"), new Guid("1f5e8297-d50f-4151-a669-844425774a18"), "World Blitz Champion 2016" },
                    { new Guid("ce5e9a57-6ba7-4892-96aa-dbffe4ef833f"), new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"), "US Chess Champion 2022" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_ChessplayerId",
                table: "Records",
                column: "ChessplayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Titles_ChessplayerId",
                table: "Titles",
                column: "ChessplayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "ChessPlayers");
        }
    }
}
