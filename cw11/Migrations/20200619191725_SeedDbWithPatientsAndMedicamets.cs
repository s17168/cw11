using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class SeedDbWithPatientsAndMedicamets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 10, "use wisely", "Xylo", "gel" },
                    { 11, "use wisely", "Paracetamol", "pills" },
                    { 12, "use wisely", "Ibuprofen", "pills" },
                    { 13, "use wisely", "Strepsils", "pills" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 101, new DateTime(1995, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pam", "Beesely" },
                    { 102, new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jim", "Halpert" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 102);
        }
    }
}
