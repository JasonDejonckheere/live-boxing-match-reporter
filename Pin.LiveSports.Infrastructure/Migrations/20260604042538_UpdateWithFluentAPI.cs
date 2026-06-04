using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWithFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "BoxingMatches",
                columns: new[] { "Id", "WinningFighterId" },
                values: new object[,]
                {
                    { new Guid("0c0d65e8-400b-4e2e-b3ed-10b2d6c0eb6f"), null },
                    { new Guid("177b8f2f-aaf9-4b74-984a-2dea3a8829b6"), null },
                    { new Guid("996159ef-db19-47a2-999f-d17a7fb669d6"), null }
                });

            migrationBuilder.InsertData(
                table: "Fighters",
                columns: new[] { "Id", "Firstname", "Lastname", "WeightClass" },
                values: new object[,]
                {
                    { new Guid("42f061a1-1a4f-4ae4-b334-0cbb01c0299f"), "Hol", "De Bol", 2 },
                    { new Guid("7e177a58-5214-4e24-95e5-d6bdd36b138b"), "Bert", "Dert", 1 },
                    { new Guid("976db6d2-7b3c-4cdb-8524-7f171b8471f4"), "Hank", "De Tank", 2 },
                    { new Guid("989fe019-952a-401b-9ed4-5868eb6c59d0"), "Steven", "Hawk", 0 },
                    { new Guid("dc39c6fa-9ebc-49c4-9590-36588a8f7f69"), "Dirk", "Hirk", 1 },
                    { new Guid("e84a0bee-047b-400c-9e71-0c3c7b6e2735"), "John", "Wick", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("0c0d65e8-400b-4e2e-b3ed-10b2d6c0eb6f"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("177b8f2f-aaf9-4b74-984a-2dea3a8829b6"));

            migrationBuilder.DeleteData(
                table: "BoxingMatches",
                keyColumn: "Id",
                keyValue: new Guid("996159ef-db19-47a2-999f-d17a7fb669d6"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("42f061a1-1a4f-4ae4-b334-0cbb01c0299f"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("7e177a58-5214-4e24-95e5-d6bdd36b138b"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("976db6d2-7b3c-4cdb-8524-7f171b8471f4"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("989fe019-952a-401b-9ed4-5868eb6c59d0"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("dc39c6fa-9ebc-49c4-9590-36588a8f7f69"));

            migrationBuilder.DeleteData(
                table: "Fighters",
                keyColumn: "Id",
                keyValue: new Guid("e84a0bee-047b-400c-9e71-0c3c7b6e2735"));

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
        }
    }
}
