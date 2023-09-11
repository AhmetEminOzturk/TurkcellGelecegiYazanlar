using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Options_OptionId",
                table: "Votes");

            migrationBuilder.DropForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_OptionId",
                table: "Votes");

            migrationBuilder.DropIndex(
                name: "IX_Votes_QuestionId",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Polls");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Votes",
                newName: "VoteTypes");

            migrationBuilder.RenameColumn(
                name: "OptionId",
                table: "Votes",
                newName: "QuestionTypes");

            migrationBuilder.AlterColumn<int>(
                name: "VoteTypes",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionTypes",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "VoteId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VoteId",
                table: "Options",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_VoteId",
                table: "Questions",
                column: "VoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_VoteId",
                table: "Options",
                column: "VoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Votes_VoteId",
                table: "Options",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Votes_VoteId",
                table: "Questions",
                column: "VoteId",
                principalTable: "Votes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Votes_VoteId",
                table: "Options");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Votes_VoteId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_VoteId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Options_VoteId",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "VoteId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "VoteId",
                table: "Options");

            migrationBuilder.RenameColumn(
                name: "VoteTypes",
                table: "Votes",
                newName: "QuestionId");

            migrationBuilder.RenameColumn(
                name: "QuestionTypes",
                table: "Votes",
                newName: "OptionId");

            migrationBuilder.AlterColumn<int>(
                name: "VoteTypes",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionTypes",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Polls",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Votes_OptionId",
                table: "Votes",
                column: "OptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_QuestionId",
                table: "Votes",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Options_OptionId",
                table: "Votes",
                column: "OptionId",
                principalTable: "Options",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Votes_Questions_QuestionId",
                table: "Votes",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");
        }
    }
}
