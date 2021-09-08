using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class BackToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "446e4f6e-c758-4aa5-90a3-5a756a24541d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7502a0fb-915b-477a-b557-08b37dfb8e37");

            migrationBuilder.AlterColumn<long>(
                name: "Long",
                table: "Events",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "Lat",
                table: "Events",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b34d799-9549-4047-a0c8-a1e34f058e71", "f788fe37-b899-4d3b-a7b5-2794a191800f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42292d88-686d-42ec-96ec-9aeb6352ddfe", "fa7bb3ad-65bd-4213-af83-4560a801f5fe", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b34d799-9549-4047-a0c8-a1e34f058e71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42292d88-686d-42ec-96ec-9aeb6352ddfe");

            migrationBuilder.AlterColumn<decimal>(
                name: "Long",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "446e4f6e-c758-4aa5-90a3-5a756a24541d", "518e14aa-dc8c-442f-9207-51a6bdab3a71", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7502a0fb-915b-477a-b557-08b37dfb8e37", "e0361a08-4a7a-4bf1-b19e-ee8d82e53ae5", "Admin", "ADMIN" });
        }
    }
}
