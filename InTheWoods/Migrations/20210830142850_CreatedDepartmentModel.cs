using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class CreatedDepartmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430484fb-b774-49d4-8cff-c85c33addf31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c6c55f-50b3-4ad8-8d49-158c1daa247e");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DocumentId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e043ba76-65e9-48f2-8db7-5fb3df98cc5c", "3cdbcbe3-545c-49a8-8e80-a881e81a9024", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb2be03a-0e09-41eb-bcff-c316fd8f6eba", "5bf538ba-a07b-42a7-8a0b-cd5682f8f7b6", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e043ba76-65e9-48f2-8db7-5fb3df98cc5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb2be03a-0e09-41eb-bcff-c316fd8f6eba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "430484fb-b774-49d4-8cff-c85c33addf31", "e3414a1b-746f-4eb4-b85c-bfaf4d2c6357", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c6c55f-50b3-4ad8-8d49-158c1daa247e", "a5d70b10-578a-49c7-892a-a62412e576e4", "Admin", "ADMIN" });
        }
    }
}
