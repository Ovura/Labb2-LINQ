using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb2LINQ.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Classes_ClassesId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Courses_CoursesID",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeacher_Classes_ClassesId",
                table: "ClassTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeacher_Teachers_TeachersID",
                table: "ClassTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CoursesID",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentsID",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Students_StudentsID",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersID",
                table: "StudentTeacher");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Teachers",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "TeachersID",
                table: "StudentTeacher",
                newName: "TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "StudentsID",
                table: "StudentTeacher",
                newName: "StudentsStudentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeachersID",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Students",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "StudentsID",
                table: "CourseStudent",
                newName: "StudentsStudentId");

            migrationBuilder.RenameColumn(
                name: "CoursesID",
                table: "CourseStudent",
                newName: "CoursesCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_StudentsID",
                table: "CourseStudent",
                newName: "IX_CourseStudent_StudentsStudentId");

            migrationBuilder.RenameColumn(
                name: "TeacherID",
                table: "Courses",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Courses",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                newName: "IX_Courses_TeacherId");

            migrationBuilder.RenameColumn(
                name: "TeachersID",
                table: "ClassTeacher",
                newName: "TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassTeacher",
                newName: "ClassesClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassTeacher_TeachersID",
                table: "ClassTeacher",
                newName: "IX_ClassTeacher_TeachersTeacherId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "ClassId");

            migrationBuilder.RenameColumn(
                name: "CoursesID",
                table: "ClassCourse",
                newName: "CoursesCourseId");

            migrationBuilder.RenameColumn(
                name: "ClassesId",
                table: "ClassCourse",
                newName: "ClassesClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassCourse_CoursesID",
                table: "ClassCourse",
                newName: "IX_ClassCourse_CoursesCourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Classes_ClassesClassId",
                table: "ClassCourse",
                column: "ClassesClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Courses_CoursesCourseId",
                table: "ClassCourse",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeacher_Classes_ClassesClassId",
                table: "ClassTeacher",
                column: "ClassesClassId",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeacher_Teachers_TeachersTeacherId",
                table: "ClassTeacher",
                column: "TeachersTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CoursesCourseId",
                table: "CourseStudent",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentsStudentId",
                table: "CourseStudent",
                column: "StudentsStudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Students_StudentsStudentId",
                table: "StudentTeacher",
                column: "StudentsStudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersTeacherId",
                table: "StudentTeacher",
                column: "TeachersTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Classes_ClassesClassId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassCourse_Courses_CoursesCourseId",
                table: "ClassCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeacher_Classes_ClassesClassId",
                table: "ClassTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassTeacher_Teachers_TeachersTeacherId",
                table: "ClassTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Teachers_TeacherId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Courses_CoursesCourseId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentsStudentId",
                table: "CourseStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Students_StudentsStudentId",
                table: "StudentTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersTeacherId",
                table: "StudentTeacher");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Teachers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "TeachersTeacherId",
                table: "StudentTeacher",
                newName: "TeachersID");

            migrationBuilder.RenameColumn(
                name: "StudentsStudentId",
                table: "StudentTeacher",
                newName: "StudentsID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentTeacher_TeachersTeacherId",
                table: "StudentTeacher",
                newName: "IX_StudentTeacher_TeachersID");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Students",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StudentsStudentId",
                table: "CourseStudent",
                newName: "StudentsID");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "CourseStudent",
                newName: "CoursesID");

            migrationBuilder.RenameIndex(
                name: "IX_CourseStudent_StudentsStudentId",
                table: "CourseStudent",
                newName: "IX_CourseStudent_StudentsID");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Courses",
                newName: "TeacherID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                newName: "IX_Courses_TeacherID");

            migrationBuilder.RenameColumn(
                name: "TeachersTeacherId",
                table: "ClassTeacher",
                newName: "TeachersID");

            migrationBuilder.RenameColumn(
                name: "ClassesClassId",
                table: "ClassTeacher",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassTeacher_TeachersTeacherId",
                table: "ClassTeacher",
                newName: "IX_ClassTeacher_TeachersID");

            migrationBuilder.RenameColumn(
                name: "ClassId",
                table: "Classes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "ClassCourse",
                newName: "CoursesID");

            migrationBuilder.RenameColumn(
                name: "ClassesClassId",
                table: "ClassCourse",
                newName: "ClassesId");

            migrationBuilder.RenameIndex(
                name: "IX_ClassCourse_CoursesCourseId",
                table: "ClassCourse",
                newName: "IX_ClassCourse_CoursesID");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Classes_ClassesId",
                table: "ClassCourse",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassCourse_Courses_CoursesID",
                table: "ClassCourse",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeacher_Classes_ClassesId",
                table: "ClassTeacher",
                column: "ClassesId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassTeacher_Teachers_TeachersID",
                table: "ClassTeacher",
                column: "TeachersID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Teachers_TeacherID",
                table: "Courses",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Courses_CoursesID",
                table: "CourseStudent",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentsID",
                table: "CourseStudent",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Students_StudentsID",
                table: "StudentTeacher",
                column: "StudentsID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTeacher_Teachers_TeachersID",
                table: "StudentTeacher",
                column: "TeachersID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
