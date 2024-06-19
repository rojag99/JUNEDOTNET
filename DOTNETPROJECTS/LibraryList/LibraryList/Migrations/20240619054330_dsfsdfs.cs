using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryList.Migrations
{
    /// <inheritdoc />
    public partial class dsfsdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "AuthorName",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
