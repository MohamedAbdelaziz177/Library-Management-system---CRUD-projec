using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_core_demo.Migrations
{
    public partial class CreateAllOtherTablesAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                table: "Books",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.MemberId);
                });

            
          // migrationBuilder.CreateTable(
          //     name: "BookBorrowTransaction",
          //     columns: table => new
          //     {
          //         booksBookId = table.Column<int>(type: "int", nullable: false),
          //         membersMemberId = table.Column<int>(type: "int", nullable: false)
          //     },
          //     constraints: table =>
          //     {
          //         table.PrimaryKey("PK_BookBorrowTransaction", x => new { x.booksBookId, x.membersMemberId });
          //         table.ForeignKey(
          //             name: "FK_BookBorrowTransaction_Books_booksBookId",
          //             column: x => x.booksBookId,
          //             principalTable: "Books",
          //             principalColumn: "BookId",
          //             onDelete: ReferentialAction.Cascade);
          //         table.ForeignKey(
          //             name: "FK_BookBorrowTransaction_members_membersMemberId",
          //             column: x => x.membersMemberId,
          //             principalTable: "members",
          //             principalColumn: "MemberId",
          //             onDelete: ReferentialAction.Cascade);
          //     });

            

            migrationBuilder.CreateTable(
                name: "bookBorrowTransactions",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookBorrowTransactions", x => new { x.bookId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_bookBorrowTransactions_Books_bookId",
                        column: x => x.bookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookBorrowTransactions_members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookName",
                table: "Books",
                column: "BookName");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");

         //   migrationBuilder.CreateIndex(
           //     name: "IX_BookBorrowTransaction_membersMemberId",
            //    table: "BookBorrowTransaction",
              //  column: "membersMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_bookBorrowTransactions_MemberId",
                table: "bookBorrowTransactions",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_categories_CategoryId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "authors");

          //  migrationBuilder.DropTable(
           //     name: "BookBorrowTransaction");

            migrationBuilder.DropTable(
                name: "bookBorrowTransactions");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookName",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
