using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBoxingMatchIsFinished : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("24576417-aeb9-4947-8df4-0ed9eab9d4ab"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("4b53ff50-d19f-408c-881a-b390ca0982cc"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("5b780773-4719-4d62-8a2d-536b02b2d22e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("06e38bef-6168-489d-933e-b7028ef421d1"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("13530808-43cf-4c29-9f48-826abc9f9128"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("46a8c0d0-e6a7-4954-b08f-a5337376a067"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("ca7541a9-1ec2-471b-9679-e487eba1ffb4"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("f461b887-30cd-49e1-9967-8d7b633a6072"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("fa509d86-3ddb-4a31-b80b-25758d6cc830"));

            migrationBuilder.AddColumn<bool>(
                name: "IsFinished",
                table: "BoxingMatches",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("058ef8d9-05f7-413e-bba7-b1f3416243e7"), "John", "Wick", 0 },
                    { new Guid("0f3a379f-ba4e-4f3a-afdf-6173f789fae4"), "Dirk", "Hirk", 1 },
                    { new Guid("11789088-b402-4844-b878-424c9385dd78"), "Bert", "Dert", 1 },
                    { new Guid("a5431437-e100-4056-bb5c-85a7596e1496"), "Hank", "De Tank", 2 },
                    { new Guid("a5535f2d-cf6f-4566-89ed-6eaf6ddeed7b"), "Steven", "Hawk", 0 },
                    { new Guid("e1e24754-cebe-4de3-a500-186215bcb503"), "Hol", "De Bol", 2 }
                });

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "FighterBlueTeamId", "FighterRedTeamId", "IsFinished", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("be50d345-3722-479c-b861-d3aee5e25899"), new Guid("058ef8d9-05f7-413e-bba7-b1f3416243e7"), new Guid("a5535f2d-cf6f-4566-89ed-6eaf6ddeed7b"), false, null },
                    { new Guid("d618d38e-2539-42cb-96aa-34abf481573d"), new Guid("e1e24754-cebe-4de3-a500-186215bcb503"), new Guid("a5431437-e100-4056-bb5c-85a7596e1496"), false, null },
                    { new Guid("e98a7217-ac1a-4f65-abe1-60a1fd99e5d7"), new Guid("11789088-b402-4844-b878-424c9385dd78"), new Guid("0f3a379f-ba4e-4f3a-afdf-6173f789fae4"), false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("be50d345-3722-479c-b861-d3aee5e25899"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("d618d38e-2539-42cb-96aa-34abf481573d"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("e98a7217-ac1a-4f65-abe1-60a1fd99e5d7"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("058ef8d9-05f7-413e-bba7-b1f3416243e7"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("0f3a379f-ba4e-4f3a-afdf-6173f789fae4"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("11789088-b402-4844-b878-424c9385dd78"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("a5431437-e100-4056-bb5c-85a7596e1496"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("a5535f2d-cf6f-4566-89ed-6eaf6ddeed7b"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e1e24754-cebe-4de3-a500-186215bcb503"));

            migrationBuilder.DropColumn(
                name: "IsFinished",
                table: "BoxingMatches");

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("06e38bef-6168-489d-933e-b7028ef421d1"), "Hol", "De Bol", 2 },
                    { new Guid("13530808-43cf-4c29-9f48-826abc9f9128"), "Bert", "Dert", 1 },
                    { new Guid("46a8c0d0-e6a7-4954-b08f-a5337376a067"), "Steven", "Hawk", 0 },
                    { new Guid("ca7541a9-1ec2-471b-9679-e487eba1ffb4"), "Dirk", "Hirk", 1 },
                    { new Guid("f461b887-30cd-49e1-9967-8d7b633a6072"), "Hank", "De Tank", 2 },
                    { new Guid("fa509d86-3ddb-4a31-b80b-25758d6cc830"), "John", "Wick", 0 }
                });

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "FighterBlueTeamId", "FighterRedTeamId", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("24576417-aeb9-4947-8df4-0ed9eab9d4ab"), new Guid("fa509d86-3ddb-4a31-b80b-25758d6cc830"), new Guid("46a8c0d0-e6a7-4954-b08f-a5337376a067"), null },
                    { new Guid("4b53ff50-d19f-408c-881a-b390ca0982cc"), new Guid("06e38bef-6168-489d-933e-b7028ef421d1"), new Guid("f461b887-30cd-49e1-9967-8d7b633a6072"), null },
                    { new Guid("5b780773-4719-4d62-8a2d-536b02b2d22e"), new Guid("13530808-43cf-4c29-9f48-826abc9f9128"), new Guid("ca7541a9-1ec2-471b-9679-e487eba1ffb4"), null }
                });
        }
    }
}
