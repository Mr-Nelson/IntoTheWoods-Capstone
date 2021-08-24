using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class EventDateToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09807546-1686-4ff0-a3d5-0bc20b353a2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebdec5ba-3bfb-4702-9e91-33923dcb4695");

            migrationBuilder.AlterColumn<string>(
                name: "EventDate",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "991b6d07-1e99-4d57-ac9d-270b133587bb", "6aabfd75-0fe7-4690-8ba7-5fa6449eec52", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "625da321-1bd2-4761-a0bb-ca0ae01f6dc3", "2e1da7a0-a9e8-41bc-9def-5a23b131dc61", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "625da321-1bd2-4761-a0bb-ca0ae01f6dc3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "991b6d07-1e99-4d57-ac9d-270b133587bb");

            migrationBuilder.AlterColumn<int>(
                name: "EventDate",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebdec5ba-3bfb-4702-9e91-33923dcb4695", "a207586f-a94f-4d90-9921-59517b58ad63", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09807546-1686-4ff0-a3d5-0bc20b353a2b", "ca9dc084-7a37-4e3a-8a16-4c5ed2668435", "Admin", "ADMIN" });
        }
    }
}
