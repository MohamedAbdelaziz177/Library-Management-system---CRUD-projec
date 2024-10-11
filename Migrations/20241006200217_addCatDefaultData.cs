using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class addCatDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Books that contain fictional stories and events.", "Fiction" },
                    { 2, "Books that are based on real facts and information.", "Non-Fiction" },
                    { 3, "Books that deal with futuristic concepts and technology.", "Science Fiction" },
                    { 4, "Books that describe the life of a real person.", "Biography" },
                    { 5, "Books that explore historical events and eras.", "History" },
                    { 6, "Books that provide guidance on personal growth and improvement.", "Self-Help" },
                    { 7, "Books that involve magical or supernatural elements in the story.", "Fantasy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "CategoryId",
                keyValue: 7);
        }
    }
}
