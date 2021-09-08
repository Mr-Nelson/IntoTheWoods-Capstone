using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class IntegersChangedToDecimalInEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44750a4c-e58b-4df1-8535-e07a337c719c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcf97f-8006-4cbc-bcb0-0ecbf3e3e68c");

            migrationBuilder.AlterColumn<decimal>(
                name: "Long",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Events",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "446e4f6e-c758-4aa5-90a3-5a756a24541d", "518e14aa-dc8c-442f-9207-51a6bdab3a71", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7502a0fb-915b-477a-b557-08b37dfb8e37", "e0361a08-4a7a-4bf1-b19e-ee8d82e53ae5", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "446e4f6e-c758-4aa5-90a3-5a756a24541d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7502a0fb-915b-477a-b557-08b37dfb8e37");

            migrationBuilder.AlterColumn<int>(
                name: "Long",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Lat",
                table: "Events",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44750a4c-e58b-4df1-8535-e07a337c719c", "805b9cfe-366c-49e0-a5a1-ba9fe6753de9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91fcf97f-8006-4cbc-bcb0-0ecbf3e3e68c", "eb04b054-593c-43a4-9150-195680854850", "Admin", "ADMIN" });
        }
    }
}
