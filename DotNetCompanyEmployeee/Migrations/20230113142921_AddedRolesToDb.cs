using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNetCompanyEmployeee.Migrations
{
    /// <inheritdoc />
    public partial class AddedRolesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "859c4ce9-09a3-4d3a-a358-2d71a79f2e80", "fabd8887-6155-4557-a3f2-c111ae95017d", "Manager", "MANAGER" },
                    { "cf8d9336-f49c-463a-8399-1ddae04ceadf", "8cc67ee7-a8b6-49d9-9062-f04e59a12be1", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "859c4ce9-09a3-4d3a-a358-2d71a79f2e80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf8d9336-f49c-463a-8399-1ddae04ceadf");
        }
    }
}
