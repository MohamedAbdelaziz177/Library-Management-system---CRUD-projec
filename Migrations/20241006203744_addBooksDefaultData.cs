using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class addBooksDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BookName", "CategoryId", "CopiesAvailable" },
                values: new object[,]
                {
                    { 1, 1, "The Great Adventure", 3, 5 },
                    { 2, 2, "Science of Tomorrow", 2, 3 },
                    { 3, 3, "History of Ancient Civilizations", 5, 7 },
                    { 4, 4, "Self-Improvement 101", 6, 10 },
                    { 5, 5, "Mysteries of the Universe", 3, 4 },
                    { 6, 6, "The Art of War", 5, 2 },
                    { 7, 7, "Fictional Worlds", 1, 8 },
                    { 8, 8, "Advanced Physics", 2, 9 },
                    { 9, 9, "The Magic Realm", 7, 6 },
                    { 10, 10, "Biography of a Legend", 4, 3 },
                    { 11, 11, "Modern Technology", 2, 4 },
                    { 12, 12, "Historical Figures", 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);
        }
    }
}
