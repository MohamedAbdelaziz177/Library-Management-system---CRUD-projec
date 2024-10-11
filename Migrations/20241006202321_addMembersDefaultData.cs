using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class addMembersDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "members",
                columns: new[] { "MemberId", "MemberEmail", "MemberName" },
                values: new object[,]
                {
                    { 1, "alice.johnson@example.com", "Alice Johnson" },
                    { 2, "bob.smith@example.com", "Bob Smith" },
                    { 3, "charlie.brown@example.com", "Charlie Brown" },
                    { 4, "diana.prince@example.com", "Diana Prince" },
                    { 5, "ethan.hunt@example.com", "Ethan Hunt" },
                    { 6, "fiona.gallagher@example.com", "Fiona Gallagher" },
                    { 7, "george.clooney@example.com", "George Clooney" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "members",
                keyColumn: "MemberId",
                keyValue: 7);
        }
    }
}
