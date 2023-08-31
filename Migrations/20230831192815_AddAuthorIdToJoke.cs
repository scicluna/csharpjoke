using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JokeApp.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorIdToJoke : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Jokes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jokes_AuthorId",
                table: "Jokes",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jokes_AspNetUsers_AuthorId",
                table: "Jokes",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jokes_AspNetUsers_AuthorId",
                table: "Jokes");

            migrationBuilder.DropIndex(
                name: "IX_Jokes_AuthorId",
                table: "Jokes");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Jokes");
        }
    }
}
