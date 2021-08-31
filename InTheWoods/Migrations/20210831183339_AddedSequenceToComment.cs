using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class AddedSequenceToComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "797e1828-fe78-4bc0-a3c3-6b7aada0034e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d3ddd3-8605-42e1-a4b1-2cd0222dcef1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44c1ec55-9eb3-4c4b-a667-55ab1cbdf49e", "bd2bed40-5bfd-4b9a-a57f-2cf21b5a3fe3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cdca996-fdae-4dca-9710-29130f006274", "7e2bd48e-2370-43f7-a6ca-6868cd5a6e7a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44c1ec55-9eb3-4c4b-a667-55ab1cbdf49e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cdca996-fdae-4dca-9710-29130f006274");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "797e1828-fe78-4bc0-a3c3-6b7aada0034e", "d061dfb8-9749-42d4-b40e-61ade204f1a0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2d3ddd3-8605-42e1-a4b1-2cd0222dcef1", "77b1b103-ff4c-4007-aac0-c98cd4761b08", "Admin", "ADMIN" });
        }
    }
}
