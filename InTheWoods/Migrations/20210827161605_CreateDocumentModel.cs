using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class CreateDocumentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69917067-a2b9-487b-9967-a828d07ab2eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70df029a-1ee1-4263-8986-a0dc09f07f3e");

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_Documents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "430484fb-b774-49d4-8cff-c85c33addf31", "e3414a1b-746f-4eb4-b85c-bfaf4d2c6357", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46c6c55f-50b3-4ad8-8d49-158c1daa247e", "a5d70b10-578a-49c7-892a-a62412e576e4", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_UserId",
                table: "Documents",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "430484fb-b774-49d4-8cff-c85c33addf31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46c6c55f-50b3-4ad8-8d49-158c1daa247e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70df029a-1ee1-4263-8986-a0dc09f07f3e", "089d4553-34ad-4331-b2f4-15e434f85464", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69917067-a2b9-487b-9967-a828d07ab2eb", "93f8cb86-e052-4a84-93ff-f3c5907d9c04", "Admin", "ADMIN" });
        }
    }
}
