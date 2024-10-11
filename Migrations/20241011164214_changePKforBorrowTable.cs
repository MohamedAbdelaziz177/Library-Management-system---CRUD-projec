using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class changePKforBorrowTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookBorrowTransactions",
                table: "bookBorrowTransactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "bookBorrowTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookBorrowTransactions",
                table: "bookBorrowTransactions",
                columns: new[] { "bookId", "MemberId", "BorrowDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_bookBorrowTransactions",
                table: "bookBorrowTransactions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BorrowDate",
                table: "bookBorrowTransactions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookBorrowTransactions",
                table: "bookBorrowTransactions",
                columns: new[] { "bookId", "MemberId" });
        }
    }
}
