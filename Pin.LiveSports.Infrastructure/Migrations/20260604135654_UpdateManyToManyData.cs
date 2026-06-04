using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pin.LiveSports.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateManyToManyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"), new Guid("72dfcb59-5548-49ab-8105-965d63f8cb4e") });

            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("4582fef0-ff06-4794-bb4f-2553a593e0e8"), new Guid("e9063b97-4348-4a0f-afe2-a5de25509f91") });

            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"), new Guid("2935d557-c9e3-4e33-8983-32760bb1739d") });

            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("e9645c58-fc32-4823-af8e-c6f690f46ae1"), new Guid("76eea230-03d7-4b86-8a42-48a8345d3b98") });

            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"), new Guid("698fe98a-78c1-4498-92e9-e8d4dc95b95e") });

            migrationBuilder.DeleteData(
                table: "BoxingMatchFighter",
                keyColumns: new[] { "AssignedMatchesId", "FightersId" },
                keyValues: new object[] { new Guid("f304d9be-e015-4c98-b1b2-f36d9cae6890"), new Guid("ece87e48-3cad-4cd4-9a53-f5b6bb5aa1d8") });

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
    }
}
