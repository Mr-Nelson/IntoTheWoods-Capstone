using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class IdValuesGeneratedUponCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8dc85582-6acf-4993-a7f9-94a6092e939d", "edf4db95-bdcd-46c6-b8e3-d23dc434967b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ffe61d2-7169-4314-a13c-a2e391b94fc9", "f211eddc-4026-424e-9b33-9c65088d94e8", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ffe61d2-7169-4314-a13c-a2e391b94fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dc85582-6acf-4993-a7f9-94a6092e939d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0f71732-8ca2-4c7e-811f-7101613e2baf", "6cd19096-9a4b-4999-9bae-2c2b8d4a7a28", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1381bac1-1c2a-4b84-ad49-7ddfff10c4ff", "5e4630c6-0a2b-42ea-a4f3-fd96c94accdc", "Admin", "ADMIN" });
        }
    }
}
