using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class EventLatLongToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b34d799-9549-4047-a0c8-a1e34f058e71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42292d88-686d-42ec-96ec-9aeb6352ddfe");

            migrationBuilder.AlterColumn<string>(
                name: "Long",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Lat",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9210e040-c7ad-45a1-a76c-be395df62384", "498a20d4-a33c-44b1-b341-c2d3d24c8e70", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8aba584-1cae-4b89-8df9-44f14fa0653a", "e249dc5a-a907-4bb7-a464-a1b3d4c8943b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9210e040-c7ad-45a1-a76c-be395df62384");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8aba584-1cae-4b89-8df9-44f14fa0653a");

            migrationBuilder.AlterColumn<long>(
                name: "Long",
                table: "Events",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Lat",
                table: "Events",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b34d799-9549-4047-a0c8-a1e34f058e71", "f788fe37-b899-4d3b-a7b5-2794a191800f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42292d88-686d-42ec-96ec-9aeb6352ddfe", "fa7bb3ad-65bd-4213-af83-4560a801f5fe", "Admin", "ADMIN" });
        }
    }
}
