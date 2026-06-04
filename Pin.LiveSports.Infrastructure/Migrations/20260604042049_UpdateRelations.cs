using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("5702ca16-a921-4309-9a33-908f58688a8f"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("bd50538d-554c-4909-8ef6-8dade75d3098"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("ed5254ac-3f4e-4814-b3ab-00b99c6bb8b1"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("04cd5d5e-4bce-428e-9bff-b7caec1e13ab"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("1785951f-93c4-491b-af87-af4c0f8304bd"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("56ca7c74-52c1-40be-9468-b8006d127ce7"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("8b9e5957-c908-4501-a98d-fc38fa82945a"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("a25af6f4-ee7e-4193-91a1-1d7fcfdb3089"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e0093bac-06f3-4665-8aa5-05818fd29578"));

            migrationBuilder.DropColumn(
                name: "FighterOneId",
                table: "BoxingMatches");

            migrationBuilder.DropColumn(
                name: "FighterTwoId",
                table: "BoxingMatches");

            migrationBuilder.CreateTable(
                name: "BoxingMatchFighter",
                columns: table => new
                {
                    AssignedMatchesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FightersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxingMatchFighter", x => new { x.AssignedMatchesId, x.FightersId });
                    table.ForeignKey(
                        name: "FK_BoxingMatchFighter_BoxingMatches_AssignedMatchesId",
                        column: x => x.AssignedMatchesId,
                        principalTable: "BoxingMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoxingMatchFighter_Fighters_FightersId",
                        column: x => x.FightersId,
                        principalTable: "Fighters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("6facfdcb-229d-4463-a5fc-a21e698d7b8b"), null },
                    { new Guid("924a742c-a558-44c2-93dd-933526669e9c"), null },
                    { new Guid("e0a5c2bb-658e-437a-9441-1ecfc5c2745d"), null }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("0925d15b-ea3a-4b9c-b487-2a036940b4c7"), "Steven", "Hawk", 0 },
                    { new Guid("25173fe0-9ebe-4e5c-a7f6-c9125feab2e8"), "Hol", "De Bol", 2 },
                    { new Guid("50c7232b-dd2a-4071-a71b-b63b0537a389"), "Hank", "De Tank", 2 },
                    { new Guid("8bcd2113-9eb3-4a51-9811-334804296bbc"), "John", "Wick", 0 },
                    { new Guid("e873df57-7506-477d-9034-6a931fe4c0bf"), "Dirk", "Hirk", 1 },
                    { new Guid("e9e1782f-d6cd-4185-b971-d0eaf446d318"), "Bert", "Dert", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoxingMatchFighter_FightersId",
                table: "BoxingMatchFighter",
                column: "FightersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxingMatchFighter");

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("6facfdcb-229d-4463-a5fc-a21e698d7b8b"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("924a742c-a558-44c2-93dd-933526669e9c"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("e0a5c2bb-658e-437a-9441-1ecfc5c2745d"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("0925d15b-ea3a-4b9c-b487-2a036940b4c7"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("25173fe0-9ebe-4e5c-a7f6-c9125feab2e8"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("50c7232b-dd2a-4071-a71b-b63b0537a389"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("8bcd2113-9eb3-4a51-9811-334804296bbc"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e873df57-7506-477d-9034-6a931fe4c0bf"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e9e1782f-d6cd-4185-b971-d0eaf446d318"));

            migrationBuilder.AddColumn<Guid>(
                name: "FighterOneId",
                table: "BoxingMatches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FighterTwoId",
                table: "BoxingMatches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "FighterOneId", "FighterTwoId", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("5702ca16-a921-4309-9a33-908f58688a8f"), new Guid("8b9e5957-c908-4501-a98d-fc38fa82945a"), new Guid("a25af6f4-ee7e-4193-91a1-1d7fcfdb3089"), null },
                    { new Guid("bd50538d-554c-4909-8ef6-8dade75d3098"), new Guid("e0093bac-06f3-4665-8aa5-05818fd29578"), new Guid("56ca7c74-52c1-40be-9468-b8006d127ce7"), null },
                    { new Guid("ed5254ac-3f4e-4814-b3ab-00b99c6bb8b1"), new Guid("04cd5d5e-4bce-428e-9bff-b7caec1e13ab"), new Guid("1785951f-93c4-491b-af87-af4c0f8304bd"), null }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("04cd5d5e-4bce-428e-9bff-b7caec1e13ab"), "Bert", "Dert", 1 },
                    { new Guid("1785951f-93c4-491b-af87-af4c0f8304bd"), "Dirk", "Hirk", 1 },
                    { new Guid("56ca7c74-52c1-40be-9468-b8006d127ce7"), "Steven", "Hawk", 0 },
                    { new Guid("8b9e5957-c908-4501-a98d-fc38fa82945a"), "Hol", "De Bol", 2 },
                    { new Guid("a25af6f4-ee7e-4193-91a1-1d7fcfdb3089"), "Hank", "De Tank", 2 },
                    { new Guid("e0093bac-06f3-4665-8aa5-05818fd29578"), "John", "Wick", 0 }
                });
        }
    }
}
