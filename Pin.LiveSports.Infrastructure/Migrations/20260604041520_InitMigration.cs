using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoxingMatches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FighterOneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FighterTwoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WinningFighterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxingMatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fighters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeightClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fighters", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxingMatches");

            migrationBuilder.DropTable(
                name: "Fighters");
        }
    }
}
