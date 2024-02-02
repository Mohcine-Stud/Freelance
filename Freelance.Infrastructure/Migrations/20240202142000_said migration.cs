using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class saidmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f953a31-9a35-411c-aae4-d0addf613589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c367399-67cd-4f32-9a9a-61a6dabf22e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "febffc17-85ea-4b9d-b0cf-b81a76723ca0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ebde786-0267-495c-be29-1a83fb53c0ce", "1", "Admin", "ADMIN" },
                    { "38bf5bfd-14da-4410-a869-0dc5cb950336", "2", "Candidat", "CANDIDAT" },
                    { "4210fed1-5d94-4378-917f-bf8414a7c7fe", "3", "Entreprise", "ENTREPRISE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ebde786-0267-495c-be29-1a83fb53c0ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38bf5bfd-14da-4410-a869-0dc5cb950336");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4210fed1-5d94-4378-917f-bf8414a7c7fe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f953a31-9a35-411c-aae4-d0addf613589", "1", "Admin", "ADMIN" },
                    { "9c367399-67cd-4f32-9a9a-61a6dabf22e8", "2", "Candidat", "CANDIDAT" },
                    { "febffc17-85ea-4b9d-b0cf-b81a76723ca0", "3", "Entreprise", "ENTREPRISE" }
                });
        }
    }
}
