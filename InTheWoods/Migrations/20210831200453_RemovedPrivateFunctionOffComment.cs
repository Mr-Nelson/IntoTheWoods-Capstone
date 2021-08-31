using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class RemovedPrivateFunctionOffComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c0f71732-8ca2-4c7e-811f-7101613e2baf", "6cd19096-9a4b-4999-9bae-2c2b8d4a7a28", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1381bac1-1c2a-4b84-ad49-7ddfff10c4ff", "5e4630c6-0a2b-42ea-a4f3-fd96c94accdc", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1381bac1-1c2a-4b84-ad49-7ddfff10c4ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0f71732-8ca2-4c7e-811f-7101613e2baf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11b0467e-4180-4636-baba-51eb77fb26ee", "def332d2-0ba8-4ffc-b429-9255ec7e47d6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "defddcae-8d9e-47b9-ab3b-7377c82fb5b6", "6e651b61-f11c-4624-a4a2-b3fc6adcc1e9", "Admin", "ADMIN" });
        }
    }
}
