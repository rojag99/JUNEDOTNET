using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryList.Migrations
{
    /// <inheritdoc />
    public partial class DJKHDJKAS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorName",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
