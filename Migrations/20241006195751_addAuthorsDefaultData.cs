using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class addAuthorsDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "AuthorId", "AuthorEmail", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Albert Einstein@virtual.com", "Albert Einstein" },
                    { 2, "john.doe@example.com", "John Doe" },
                    { 3, "jane.smith@example.com", "Jane Smith" },
                    { 4, "emily.johnson@example.com", "Emily Johnson" },
                    { 5, "michael.brown@example.com", "Michael Brown" },
                    { 6, "linda.white@example.com", "Linda White" },
                    { 7, "Moaziz@virtual.com", "Mo Aziz" },
                    { 8, "Maaziz@virtual.com", "Ma Aziz" },
                    { 9, "Moahziz@virtual.com", "Moh Aziz" },
                    { 10, "meeaziz@virtual.com", "Mee Aziz" },
                    { 11, "Moazaziz@virtual.com", "Moaz Aziz" },
                    { 12, "Mozaaziz@virtual.com", "Moza Aziz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "AuthorId",
                keyValue: 12);
        }
    }
}
