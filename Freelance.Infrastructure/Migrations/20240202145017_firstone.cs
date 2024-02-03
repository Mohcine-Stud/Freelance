using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ee05546-baa0-42c8-ba92-a0dc04cb5c6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8e51ebb-2c16-4f26-9b92-d6c4c3143d8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd3b9c5-3583-4023-bc97-5a1715e33cd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e665137-11ab-431c-b3da-51dee193b026", "3", "Entreprise", "ENTREPRISE" },
                    { "31aad63a-c145-44c3-8a7b-02bbb23e8f2d", "2", "Candidat", "CANDIDAT" },
                    { "80e96366-3957-4fd4-9952-cc6956e809bd", "1", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e665137-11ab-431c-b3da-51dee193b026");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31aad63a-c145-44c3-8a7b-02bbb23e8f2d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80e96366-3957-4fd4-9952-cc6956e809bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ee05546-baa0-42c8-ba92-a0dc04cb5c6e", "3", "Entreprise", "ENTREPRISE" },
                    { "a8e51ebb-2c16-4f26-9b92-d6c4c3143d8f", "2", "Candidat", "CANDIDAT" },
                    { "ffd3b9c5-3583-4023-bc97-5a1715e33cd4", "1", "Admin", "ADMIN" }
                });
        }
    }
}
