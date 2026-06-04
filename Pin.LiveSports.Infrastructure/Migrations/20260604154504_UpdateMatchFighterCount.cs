using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMatchFighterCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxingMatchFighter");

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("2935d557-c9e3-4e33-8983-32760bb1739d"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("698fe98a-78c1-4498-92e9-e8d4dc95b95e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("72dfcb59-5548-49ab-8105-965d63f8cb4e"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("76eea230-03d7-4b86-8a42-48a8345d3b98"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e9063b97-4348-4a0f-afe2-a5de25509f91"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("ece87e48-3cad-4cd4-9a53-f5b6bb5aa1d8"));

            migrationBuilder.AddColumn<Guid>(
                name: "FighterBlueTeamId",
                table: "BoxingMatches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FighterRedTeamId",
                table: "BoxingMatches",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_BoxingMatches_FighterBlueTeamId",
                table: "BoxingMatches",
                column: "FighterBlueTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_BoxingMatches_FighterRedTeamId",
                table: "BoxingMatches",
                column: "FighterRedTeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoxingMatches_Fighters_FighterBlueTeamId",
                table: "BoxingMatches",
                column: "FighterBlueTeamId",
                principalTable: "Fighters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BoxingMatches_Fighters_FighterRedTeamId",
                table: "BoxingMatches",
                column: "FighterRedTeamId",
                principalTable: "Fighters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoxingMatches_Fighters_FighterBlueTeamId",
                table: "BoxingMatches");

            migrationBuilder.DropForeignKey(
                name: "FK_BoxingMatches_Fighters_FighterRedTeamId",
                table: "BoxingMatches");

            migrationBuilder.DropIndex(
                name: "IX_BoxingMatches_FighterBlueTeamId",
                table: "BoxingMatches");

            migrationBuilder.DropIndex(
                name: "IX_BoxingMatches_FighterRedTeamId",
                table: "BoxingMatches");

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

            migrationBuilder.DropColumn(
                name: "FighterBlueTeamId",
                table: "BoxingMatches");

            migrationBuilder.DropColumn(
                name: "FighterRedTeamId",
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
                    { new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"), null },
                    { new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"), null },
                    { new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"), null }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("2935d557-c9e3-4e33-8983-32760bb1739d"), "John", "Wick", 0 },
                    { new Guid("698fe98a-78c1-4498-92e9-e8d4dc95b95e"), "Hol", "De Bol", 2 },
                    { new Guid("72dfcb59-5548-49ab-8105-965d63f8cb4e"), "Bert", "Dert", 1 },
                    { new Guid("76eea230-03d7-4b86-8a42-48a8345d3b98"), "Steven", "Hawk", 0 },
                    { new Guid("e9063b97-4348-4a0f-afe2-a5de25509f91"), "Dirk", "Hirk", 1 },
                    { new Guid("ece87e48-3cad-4cd4-9a53-f5b6bb5aa1d8"), "Hank", "De Tank", 2 }
                });

            migrationBuilder.InsertData(
                table: "BoxingMatchFighter",
                columns: new[] { "AssignedMatchesId", "FightersId" },
                values: new object[,]
                {
                    { new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"), new Guid("72dfcb59-5548-49ab-8105-965d63f8cb4e") },
                    { new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"), new Guid("e9063b97-4348-4a0f-afe2-a5de25509f91") },
                    { new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"), new Guid("2935d557-c9e3-4e33-8983-32760bb1739d") },
                    { new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"), new Guid("76eea230-03d7-4b86-8a42-48a8345d3b98") },
                    { new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"), new Guid("698fe98a-78c1-4498-92e9-e8d4dc95b95e") },
                    { new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"), new Guid("ece87e48-3cad-4cd4-9a53-f5b6bb5aa1d8") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BoxingMatchFighter_FightersId",
                table: "BoxingMatchFighter",
                column: "FightersId");
        }
    }
}
