using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class AutoIncrementAddedToCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87f8d9b0-4f07-440a-9199-e7bbaf3ad6ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d10aa3f9-8c05-467d-84af-0725aba9e548");

            migrationBuilder.AddColumn<bool>(
                name: "AutoIncrement",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41061138-99f3-4d1f-b3fb-f8ee7f14055c", "72a82739-574d-409a-9110-735ddc3e1aef", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d4e7b7c-524c-4d87-98ee-8fae68fa56e6", "0452dbd8-7726-46b1-a5ce-d1f9a8becf24", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d4e7b7c-524c-4d87-98ee-8fae68fa56e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41061138-99f3-4d1f-b3fb-f8ee7f14055c");

            migrationBuilder.DropColumn(
                name: "AutoIncrement",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d10aa3f9-8c05-467d-84af-0725aba9e548", "06491484-5b07-4f38-89ad-6bc5cb0eb128", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87f8d9b0-4f07-440a-9199-e7bbaf3ad6ba", "b1929f07-9371-47a3-a1e6-9514d3c79fcd", "Admin", "ADMIN" });
        }
    }
}
