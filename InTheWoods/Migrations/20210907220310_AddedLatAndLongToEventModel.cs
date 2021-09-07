using Microsoft.EntityFrameworkCore.Migrations;

namespace InTheWoods.Migrations
{
    public partial class AddedLatAndLongToEventModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ffe61d2-7169-4314-a13c-a2e391b94fc9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dc85582-6acf-4993-a7f9-94a6092e939d");

            migrationBuilder.RenameColumn(
                name: "EventLocation",
                table: "Events",
                newName: "Long");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6b4fe2d0-feef-4305-af1e-7b86df068d3b", "1a1c3cec-7895-4b1e-aa14-4571c3544262", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "171cf545-265a-43b4-add5-a35b7aed0e34", "548071ba-05c1-45ad-8ce8-fcf9badfcb3d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "171cf545-265a-43b4-add5-a35b7aed0e34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b4fe2d0-feef-4305-af1e-7b86df068d3b");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Long",
                table: "Events",
                newName: "EventLocation");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8dc85582-6acf-4993-a7f9-94a6092e939d", "edf4db95-bdcd-46c6-b8e3-d23dc434967b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ffe61d2-7169-4314-a13c-a2e391b94fc9", "f211eddc-4026-424e-9b33-9c65088d94e8", "Admin", "ADMIN" });
        }
    }
}
