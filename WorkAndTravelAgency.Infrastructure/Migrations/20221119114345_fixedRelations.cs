using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkAndTravelAgency.Infrastructure.Migrations
{
    public partial class fixedRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "Journeys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgentId",
                table: "JobTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba3d59b3-3509-4992-a0d1-de4704ba702e", "AQAAAAEAACcQAAAAEKeCKM3KAgFpJhH9bsDxmGZzMCiwMuemaz9BiHkRtq5DP391QQhNvqtnWSKg/RZVjw==", "477c973f-96d2-4a72-b5de-7b25e8ffd9d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b09db3-11fe-45f8-bb4b-2552e34ac8ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8531cf65-7cc1-4e05-996b-4ba1d00e879c", "AQAAAAEAACcQAAAAEDLS/7NldTN0JdlKXo65Wd+qCCzyJhPXriOu211psVXOrCz4aeoRKvno6R5KdAipfA==", "21ba3abd-70d1-4495-9b52-5dd930d185bc" });

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "JobTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Journeys",
                keyColumn: "Id",
                keyValue: 1,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Journeys",
                keyColumn: "Id",
                keyValue: 2,
                column: "AgentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Journeys",
                keyColumn: "Id",
                keyValue: 3,
                column: "AgentId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Journeys_AgentId",
                table: "Journeys",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypes_AgentId",
                table: "JobTypes",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobTypes_Agents_AgentId",
                table: "JobTypes",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Journeys_Agents_AgentId",
                table: "Journeys",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTypes_Agents_AgentId",
                table: "JobTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Journeys_Agents_AgentId",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_Journeys_AgentId",
                table: "Journeys");

            migrationBuilder.DropIndex(
                name: "IX_JobTypes_AgentId",
                table: "JobTypes");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Journeys");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "JobTypes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d77e083-1bdf-4459-b59e-08e4a12d3308", "AQAAAAEAACcQAAAAEGnYgXVMjv3HqIHysYlaT14tJiAay8VLLzEemmccYoAKMdZ3FcNj3gwrlTXB8+AnIA==", "8aa1bfb3-12d2-4028-acfa-d6093b57cfe5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92b09db3-11fe-45f8-bb4b-2552e34ac8ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b08acdcc-679e-457a-8c15-f587388a1eef", "AQAAAAEAACcQAAAAEFkMwIamsRrif6KzcfLdff/rweq+8FBBOdNB1lAQWasjDjke7lYDDtXq3J71ZEnFJQ==", "e7e9a5e7-8412-44c4-b658-723ba6865a9d" });
        }
    }
}
