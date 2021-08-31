using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class RemoveSequenceFromComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d10aa3f9-8c05-467d-84af-0725aba9e548", "06491484-5b07-4f38-89ad-6bc5cb0eb128", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87f8d9b0-4f07-440a-9199-e7bbaf3ad6ba", "b1929f07-9371-47a3-a1e6-9514d3c79fcd", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87f8d9b0-4f07-440a-9199-e7bbaf3ad6ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d10aa3f9-8c05-467d-84af-0725aba9e548");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44c1ec55-9eb3-4c4b-a667-55ab1cbdf49e", "bd2bed40-5bfd-4b9a-a57f-2cf21b5a3fe3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4cdca996-fdae-4dca-9710-29130f006274", "7e2bd48e-2370-43f7-a6ca-6868cd5a6e7a", "Admin", "ADMIN" });
        }
    }
}
