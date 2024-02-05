using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addConstructers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CondidatComps_Competences_CompetenceId",
                table: "CondidatComps");

            migrationBuilder.DropForeignKey(
                name: "FK_CondidatComps_ComptenceDmExpertises_IdCompNavigationId",
                table: "CondidatComps");

            migrationBuilder.DropIndex(
                name: "IX_CondidatComps_CompetenceId",
                table: "CondidatComps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aae7b6d-a50e-45ec-8e49-740b61929bfe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9529778e-4fa8-4119-86b1-4742d2ce7e31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6875c6-b1c0-40fc-a6bc-7388236630f1");

            migrationBuilder.DropColumn(
                name: "CompetenceId",
                table: "CondidatComps");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "822c0191-e47b-4826-af13-33f87f5e334a", "3", "Entreprise", "ENTREPRISE" },
                    { "d2bb153c-5275-4b67-a1b8-42a19ad08b3c", "1", "Admin", "ADMIN" },
                    { "eae58efe-1a3c-4e7e-b756-2b17c1ffa939", "2", "Candidat", "CANDIDAT" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CondidatComps_Competences_IdCompNavigationId",
                table: "CondidatComps",
                column: "IdCompNavigationId",
                principalTable: "Competences",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CondidatComps_Competences_IdCompNavigationId",
                table: "CondidatComps");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "822c0191-e47b-4826-af13-33f87f5e334a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2bb153c-5275-4b67-a1b8-42a19ad08b3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae58efe-1a3c-4e7e-b756-2b17c1ffa939");

            migrationBuilder.AddColumn<int>(
                name: "CompetenceId",
                table: "CondidatComps",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7aae7b6d-a50e-45ec-8e49-740b61929bfe", "2", "Candidat", "CANDIDAT" },
                    { "9529778e-4fa8-4119-86b1-4742d2ce7e31", "3", "Entreprise", "ENTREPRISE" },
                    { "ed6875c6-b1c0-40fc-a6bc-7388236630f1", "1", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CondidatComps_CompetenceId",
                table: "CondidatComps",
                column: "CompetenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_CondidatComps_Competences_CompetenceId",
                table: "CondidatComps",
                column: "CompetenceId",
                principalTable: "Competences",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CondidatComps_ComptenceDmExpertises_IdCompNavigationId",
                table: "CondidatComps",
                column: "IdCompNavigationId",
                principalTable: "ComptenceDmExpertises",
                principalColumn: "Id");
        }
    }
}
