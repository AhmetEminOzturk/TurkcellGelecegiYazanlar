using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newTry2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionTypes",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "VoteTypes",
                table: "Votes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionTypes",
                table: "Votes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoteTypes",
                table: "Votes",
                type: "int",
                nullable: true);
        }
    }
}
