using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class ChangedIntFormat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2dba484-4a5a-42b9-a886-51759da1eda8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd5b9d54-7c9e-42a8-b145-083bdb45d19d");

            migrationBuilder.AlterColumn<int>(
                name: "Long",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "Lat",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44750a4c-e58b-4df1-8535-e07a337c719c", "805b9cfe-366c-49e0-a5a1-ba9fe6753de9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91fcf97f-8006-4cbc-bcb0-0ecbf3e3e68c", "eb04b054-593c-43a4-9150-195680854850", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44750a4c-e58b-4df1-8535-e07a337c719c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcf97f-8006-4cbc-bcb0-0ecbf3e3e68c");

            migrationBuilder.AlterColumn<long>(
                name: "Long",
                table: "Events",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Lat",
                table: "Events",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd5b9d54-7c9e-42a8-b145-083bdb45d19d", "2620217f-756c-47fa-bfa2-9d1c2ca18537", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2dba484-4a5a-42b9-a886-51759da1eda8", "de149013-6ba4-48e4-a562-01db65567f83", "Admin", "ADMIN" });
        }
    }
}
