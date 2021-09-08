using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class LatAndLongChangedToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "171cf545-265a-43b4-add5-a35b7aed0e34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b4fe2d0-feef-4305-af1e-7b86df068d3b");

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
                values: new object[] { "cd5b9d54-7c9e-42a8-b145-083bdb45d19d", "2620217f-756c-47fa-bfa2-9d1c2ca18537", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2dba484-4a5a-42b9-a886-51759da1eda8", "de149013-6ba4-48e4-a562-01db65567f83", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2dba484-4a5a-42b9-a886-51759da1eda8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd5b9d54-7c9e-42a8-b145-083bdb45d19d");

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
                values: new object[] { "6b4fe2d0-feef-4305-af1e-7b86df068d3b", "1a1c3cec-7895-4b1e-aa14-4571c3544262", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "171cf545-265a-43b4-add5-a35b7aed0e34", "548071ba-05c1-45ad-8ce8-fcf9badfcb3d", "Admin", "ADMIN" });
        }
    }
}
