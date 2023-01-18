using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCompanyEmployeee.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserFiledsForRefreshToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "859c4ce9-09a3-4d3a-a358-2d71a79f2e80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8d9336-f49c-463a-8399-1ddae04ceadf");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "363a0981-2abd-433a-a430-7210df3886ee", "6b563212-0214-4ea6-ade2-74f1f7bceb67", "Manager", "MANAGER" },
                    { "98d10d61-e733-41ae-bf4a-c5c64644fa8b", "2b312752-b91e-4756-80b6-5fa7f0ebe088", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "363a0981-2abd-433a-a430-7210df3886ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98d10d61-e733-41ae-bf4a-c5c64644fa8b");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiryTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "859c4ce9-09a3-4d3a-a358-2d71a79f2e80", "fabd8887-6155-4557-a3f2-c111ae95017d", "Manager", "MANAGER" },
                    { "cf8d9336-f49c-463a-8399-1ddae04ceadf", "8cc67ee7-a8b6-49d9-9062-f04e59a12be1", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
