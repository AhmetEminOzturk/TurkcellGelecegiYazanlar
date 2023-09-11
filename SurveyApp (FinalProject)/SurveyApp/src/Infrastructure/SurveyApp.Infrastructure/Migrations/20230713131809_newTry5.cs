using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newTry5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Polls_PollId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_PollId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "PollId",
                table: "Votes");

            migrationBuilder.CreateTable(
                name: "PollVote",
                columns: table => new
                {
                    PollsId = table.Column<int>(type: "int", nullable: false),
                    VotesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollVote", x => new { x.PollsId, x.VotesId });
                    table.ForeignKey(
                        name: "FK_PollVote_Polls_PollsId",
                        column: x => x.PollsId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PollVote_Votes_VotesId",
                        column: x => x.VotesId,
                        principalTable: "Votes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PollVote_VotesId",
                table: "PollVote",
                column: "VotesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PollVote");

            migrationBuilder.AddColumn<int>(
                name: "PollId",
                table: "Votes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_PollId",
                table: "Votes",
                column: "PollId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Polls_PollId",
                table: "Votes",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id");
        }
    }
}
