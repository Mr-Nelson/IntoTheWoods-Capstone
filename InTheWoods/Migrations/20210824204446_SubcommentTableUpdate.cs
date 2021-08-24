using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class SubcommentTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "625da321-1bd2-4761-a0bb-ca0ae01f6dc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991b6d07-1e99-4d57-ac9d-270b133587bb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32d84c8b-55c6-4f79-a650-3d035561a991", "3281f525-400f-4f4a-ae78-ae98aabe2f78", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "483b1d92-578e-4bac-8b4f-07e532ddadb1", "beb8180d-9104-4275-adb5-2a5d667ebd5a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32d84c8b-55c6-4f79-a650-3d035561a991");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "483b1d92-578e-4bac-8b4f-07e532ddadb1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "991b6d07-1e99-4d57-ac9d-270b133587bb", "6aabfd75-0fe7-4690-8ba7-5fa6449eec52", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "625da321-1bd2-4761-a0bb-ca0ae01f6dc3", "2e1da7a0-a9e8-41bc-9def-5a23b131dc61", "Admin", "ADMIN" });
        }
    }
}
