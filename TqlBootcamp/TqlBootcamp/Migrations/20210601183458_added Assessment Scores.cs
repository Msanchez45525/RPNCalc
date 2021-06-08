using Microsoft.EntityFrameworkCore.Migrations;

namespace TqlBootcamp.Migrations
{
    public partial class addedAssessmentScores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentScore_Assessments_AssessmentId",
                table: "AssessmentScore");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentScore_Students_StudentId",
                table: "AssessmentScore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssessmentScore",
                table: "AssessmentScore");

            migrationBuilder.RenameTable(
                name: "AssessmentScore",
                newName: "AssessmentScores");

            migrationBuilder.RenameIndex(
                name: "IX_AssessmentScore_StudentId",
                table: "AssessmentScores",
                newName: "IX_AssessmentScores_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssessmentScore_AssessmentId",
                table: "AssessmentScores",
                newName: "IX_AssessmentScores_AssessmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssessmentScores",
                table: "AssessmentScores",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentScores_Assessments_AssessmentId",
                table: "AssessmentScores",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentScores_Students_StudentId",
                table: "AssessmentScores",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentScores_Assessments_AssessmentId",
                table: "AssessmentScores");

            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentScores_Students_StudentId",
                table: "AssessmentScores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssessmentScores",
                table: "AssessmentScores");

            migrationBuilder.RenameTable(
                name: "AssessmentScores",
                newName: "AssessmentScore");

            migrationBuilder.RenameIndex(
                name: "IX_AssessmentScores_StudentId",
                table: "AssessmentScore",
                newName: "IX_AssessmentScore_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_AssessmentScores_AssessmentId",
                table: "AssessmentScore",
                newName: "IX_AssessmentScore_AssessmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssessmentScore",
                table: "AssessmentScore",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentScore_Assessments_AssessmentId",
                table: "AssessmentScore",
                column: "AssessmentId",
                principalTable: "Assessments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentScore_Students_StudentId",
                table: "AssessmentScore",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
