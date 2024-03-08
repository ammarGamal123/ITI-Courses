using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment3.Migrations
{
    /// <inheritdoc />
    public partial class EditRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Courses_CourseId",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Courses_CourseId1",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Traines_TraineeId",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Traines_TraineeId1",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_CourseId1",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_CourseId1",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_CourseResults_CourseId",
                table: "CourseResults");

            migrationBuilder.DropIndex(
                name: "IX_CourseResults_CourseId1",
                table: "CourseResults");

            migrationBuilder.DropIndex(
                name: "IX_CourseResults_TraineeId1",
                table: "CourseResults");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "CourseResults");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "CourseResults");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Instructors",
                newName: "InstructorCrsId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_CourseId",
                table: "Instructors",
                newName: "IX_Instructors_InstructorCrsId");

            migrationBuilder.RenameColumn(
                name: "TraineeId1",
                table: "CourseResults",
                newName: "CourseResultTranId");

            migrationBuilder.RenameColumn(
                name: "TraineeId",
                table: "CourseResults",
                newName: "CourseResultCrsId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseResults_TraineeId",
                table: "CourseResults",
                newName: "IX_CourseResults_CourseResultCrsId");

            migrationBuilder.AddColumn<int>(
                name: "CourseResultId",
                table: "Traines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseResultId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Traines_CourseResultId",
                table: "Traines",
                column: "CourseResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseResultId",
                table: "Courses",
                column: "CourseResultId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Courses_CourseResultCrsId",
                table: "CourseResults",
                column: "CourseResultCrsId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Traines_CourseResultCrsId",
                table: "CourseResults",
                column: "CourseResultCrsId",
                principalTable: "Traines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseResults_CourseResultId",
                table: "Courses",
                column: "CourseResultId",
                principalTable: "CourseResults",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_InstructorCrsId",
                table: "Instructors",
                column: "InstructorCrsId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Traines_CourseResults_CourseResultId",
                table: "Traines",
                column: "CourseResultId",
                principalTable: "CourseResults",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Courses_CourseResultCrsId",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseResults_Traines_CourseResultCrsId",
                table: "CourseResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseResults_CourseResultId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Courses_InstructorCrsId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Traines_CourseResults_CourseResultId",
                table: "Traines");

            migrationBuilder.DropIndex(
                name: "IX_Traines_CourseResultId",
                table: "Traines");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseResultId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseResultId",
                table: "Traines");

            migrationBuilder.DropColumn(
                name: "CourseResultId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "InstructorCrsId",
                table: "Instructors",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_InstructorCrsId",
                table: "Instructors",
                newName: "IX_Instructors_CourseId");

            migrationBuilder.RenameColumn(
                name: "CourseResultTranId",
                table: "CourseResults",
                newName: "TraineeId1");

            migrationBuilder.RenameColumn(
                name: "CourseResultCrsId",
                table: "CourseResults",
                newName: "TraineeId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseResults_CourseResultCrsId",
                table: "CourseResults",
                newName: "IX_CourseResults_TraineeId");

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "CourseResults",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "CourseResults",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseId1",
                table: "Instructors",
                column: "CourseId1",
                unique: true,
                filter: "[CourseId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResults_CourseId",
                table: "CourseResults",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResults_CourseId1",
                table: "CourseResults",
                column: "CourseId1",
                unique: true,
                filter: "[CourseId1] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CourseResults_TraineeId1",
                table: "CourseResults",
                column: "TraineeId1",
                unique: true,
                filter: "[TraineeId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Courses_CourseId",
                table: "CourseResults",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Courses_CourseId1",
                table: "CourseResults",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Traines_TraineeId",
                table: "CourseResults",
                column: "TraineeId",
                principalTable: "Traines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseResults_Traines_TraineeId1",
                table: "CourseResults",
                column: "TraineeId1",
                principalTable: "Traines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId",
                table: "Instructors",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Courses_CourseId1",
                table: "Instructors",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
