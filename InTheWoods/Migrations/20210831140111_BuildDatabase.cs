using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class BuildDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc865815-f561-4e39-9cd2-6786e23b4447");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3c6d9f0-8a28-46c9-adc4-fd087d5e640a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91c97575-c7d4-485c-b4e4-f894cc359189", "f353d1c4-0577-46b8-88cc-88c301fe5433", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0eb054d4-303d-4d31-af41-e06376a54472", "c693d3e8-38b3-448b-923b-093b9fcea45a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0eb054d4-303d-4d31-af41-e06376a54472");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91c97575-c7d4-485c-b4e4-f894cc359189");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc865815-f561-4e39-9cd2-6786e23b4447", "53e40557-6a16-4dcc-a0e6-c49b0061a804", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3c6d9f0-8a28-46c9-adc4-fd087d5e640a", "105fbdaa-be17-4b75-9606-ca9dc28296f0", "Admin", "ADMIN" });
        }
    }
}
