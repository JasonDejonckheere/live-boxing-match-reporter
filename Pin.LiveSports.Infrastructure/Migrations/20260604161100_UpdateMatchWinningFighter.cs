using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMatchWinningFighter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("15f76db9-82eb-41f7-8722-1ea05c1870d0"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("8c4925c1-bf32-4722-b106-4533eb7a2f76"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("d40987e1-e648-41b3-b7bf-b649706118d0"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("13cd89c1-b0f8-4528-b48a-b88a57613be0"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("1cebe6c8-71c6-4c2e-8e3d-93b2dbe7a33f"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("3eee2aef-7794-4660-a539-e66c161778b4"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("bbd94e0b-2ab2-4513-9b6d-b0c9e588d91e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e09ee730-91d2-4207-ae38-573bfc6d1dc2"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("f6058402-76c6-4531-9723-f00c23d5a7ab"));

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

            migrationBuilder.CreateIndex(
                name: "IX_BoxingMatches_WinningFighterId",
                table: "BoxingMatches",
                column: "WinningFighterId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoxingMatches_Fighters_WinningFighterId",
                table: "BoxingMatches",
                column: "WinningFighterId",
                principalTable: "Fighters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoxingMatches_Fighters_WinningFighterId",
                table: "BoxingMatches");

            migrationBuilder.DropIndex(
                name: "IX_BoxingMatches_WinningFighterId",
                table: "BoxingMatches");

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

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("13cd89c1-b0f8-4528-b48a-b88a57613be0"), "Bert", "Dert", 1 },
                    { new Guid("1cebe6c8-71c6-4c2e-8e3d-93b2dbe7a33f"), "Steven", "Hawk", 0 },
                    { new Guid("3eee2aef-7794-4660-a539-e66c161778b4"), "Hank", "De Tank", 2 },
                    { new Guid("bbd94e0b-2ab2-4513-9b6d-b0c9e588d91e"), "John", "Wick", 0 },
                    { new Guid("e09ee730-91d2-4207-ae38-573bfc6d1dc2"), "Dirk", "Hirk", 1 },
                    { new Guid("f6058402-76c6-4531-9723-f00c23d5a7ab"), "Hol", "De Bol", 2 }
                });

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "FighterBlueTeamId", "FighterRedTeamId", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("15f76db9-82eb-41f7-8722-1ea05c1870d0"), new Guid("f6058402-76c6-4531-9723-f00c23d5a7ab"), new Guid("3eee2aef-7794-4660-a539-e66c161778b4"), null },
                    { new Guid("8c4925c1-bf32-4722-b106-4533eb7a2f76"), new Guid("bbd94e0b-2ab2-4513-9b6d-b0c9e588d91e"), new Guid("1cebe6c8-71c6-4c2e-8e3d-93b2dbe7a33f"), null },
                    { new Guid("d40987e1-e648-41b3-b7bf-b649706118d0"), new Guid("13cd89c1-b0f8-4528-b48a-b88a57613be0"), new Guid("e09ee730-91d2-4207-ae38-573bfc6d1dc2"), null }
                });
        }
    }
}
