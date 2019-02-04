using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Data.Migrations
{
    public partial class AddedTableBookCopy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowEvents_Books_BookId",
                table: "BorrowEvents");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BorrowEvents",
                newName: "BookCopyId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowEvents_BookId",
                table: "BorrowEvents",
                newName: "IX_BorrowEvents_BookCopyId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Books",
                newName: "AvailableCopies");

            migrationBuilder.CreateTable(
                name: "BookCopies",
                columns: table => new
                {
                    BookCopyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCopies", x => x.BookCopyId);
                    table.ForeignKey(
                        name: "FK_BookCopies_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookCopies_BookId",
                table: "BookCopies",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowEvents_BookCopies_BookCopyId",
                table: "BorrowEvents",
                column: "BookCopyId",
                principalTable: "BookCopies",
                principalColumn: "BookCopyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowEvents_BookCopies_BookCopyId",
                table: "BorrowEvents");

            migrationBuilder.DropTable(
                name: "BookCopies");

            migrationBuilder.RenameColumn(
                name: "BookCopyId",
                table: "BorrowEvents",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowEvents_BookCopyId",
                table: "BorrowEvents",
                newName: "IX_BorrowEvents_BookId");

            migrationBuilder.RenameColumn(
                name: "AvailableCopies",
                table: "Books",
                newName: "Status");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowEvents_Books_BookId",
                table: "BorrowEvents",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
