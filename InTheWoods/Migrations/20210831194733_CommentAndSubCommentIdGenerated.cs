using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class CommentAndSubCommentIdGenerated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26e1607a-ee96-4c33-bde9-7f71d903e110");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e607485-fcd1-4051-acf8-54b6fcbbefa8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4dd7636a-4b19-4864-b523-ffe849a18e9c", "7f1f5e07-25d7-47f0-a5ad-70704a137e6c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2577845-e562-45d4-ad4a-fb5d8ce74ab9", "7234a170-98ad-4a70-941b-0091cd013beb", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4dd7636a-4b19-4864-b523-ffe849a18e9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2577845-e562-45d4-ad4a-fb5d8ce74ab9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26e1607a-ee96-4c33-bde9-7f71d903e110", "aaba0040-ca1f-4f68-a281-811bf992d072", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e607485-fcd1-4051-acf8-54b6fcbbefa8", "171565f2-edd8-4ea3-aa8a-e6976be3bbdb", "Admin", "ADMIN" });
        }
    }
}
