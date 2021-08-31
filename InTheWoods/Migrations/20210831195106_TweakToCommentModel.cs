using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class TweakToCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dd7636a-4b19-4864-b523-ffe849a18e9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2577845-e562-45d4-ad4a-fb5d8ce74ab9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11b0467e-4180-4636-baba-51eb77fb26ee", "def332d2-0ba8-4ffc-b429-9255ec7e47d6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "defddcae-8d9e-47b9-ab3b-7377c82fb5b6", "6e651b61-f11c-4624-a4a2-b3fc6adcc1e9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11b0467e-4180-4636-baba-51eb77fb26ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "defddcae-8d9e-47b9-ab3b-7377c82fb5b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dd7636a-4b19-4864-b523-ffe849a18e9c", "7f1f5e07-25d7-47f0-a5ad-70704a137e6c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2577845-e562-45d4-ad4a-fb5d8ce74ab9", "7234a170-98ad-4a70-941b-0091cd013beb", "Admin", "ADMIN" });
        }
    }
}
