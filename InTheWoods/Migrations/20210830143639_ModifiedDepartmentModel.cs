using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class ModifiedDepartmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e043ba76-65e9-48f2-8db7-5fb3df98cc5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb2be03a-0e09-41eb-bcff-c316fd8f6eba");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                table: "Departments",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc865815-f561-4e39-9cd2-6786e23b4447", "53e40557-6a16-4dcc-a0e6-c49b0061a804", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e3c6d9f0-8a28-46c9-adc4-fd087d5e640a", "105fbdaa-be17-4b75-9606-ca9dc28296f0", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UserId",
                table: "Departments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_AspNetUsers_UserId",
                table: "Departments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_UserId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_UserId",
                table: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc865815-f561-4e39-9cd2-6786e23b4447");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3c6d9f0-8a28-46c9-adc4-fd087d5e640a");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "DocumentId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e043ba76-65e9-48f2-8db7-5fb3df98cc5c", "3cdbcbe3-545c-49a8-8e80-a881e81a9024", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb2be03a-0e09-41eb-bcff-c316fd8f6eba", "5bf538ba-a07b-42a7-8a0b-cd5682f8f7b6", "Admin", "ADMIN" });
        }
    }
}
