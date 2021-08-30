using System;
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
                keyValue: "9fa228f5-4075-4aab-aec9-a9c35e2ceeb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c73daaf4-bd12-414b-9038-b72b765eab66");

            migrationBuilder.AlterColumn<string>(
                name: "EventDate",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70df029a-1ee1-4263-8986-a0dc09f07f3e", "089d4553-34ad-4331-b2f4-15e434f85464", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69917067-a2b9-487b-9967-a828d07ab2eb", "93f8cb86-e052-4a84-93ff-f3c5907d9c04", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69917067-a2b9-487b-9967-a828d07ab2eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70df029a-1ee1-4263-8986-a0dc09f07f3e");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "EventDate",
                table: "Events",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c73daaf4-bd12-414b-9038-b72b765eab66", "a82cfffd-ee23-411c-aa58-bb89712b5320", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9fa228f5-4075-4aab-aec9-a9c35e2ceeb5", "21a53bf2-5c14-437a-a054-46891551a9e1", "Admin", "ADMIN" });
        }
    }
}
