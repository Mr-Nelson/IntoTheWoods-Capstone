using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class ReguildTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "26e1607a-ee96-4c33-bde9-7f71d903e110", "aaba0040-ca1f-4f68-a281-811bf992d072", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e607485-fcd1-4051-acf8-54b6fcbbefa8", "171565f2-edd8-4ea3-aa8a-e6976be3bbdb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e1607a-ee96-4c33-bde9-7f71d903e110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e607485-fcd1-4051-acf8-54b6fcbbefa8");

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
    }
}
