using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace smart_learner.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentFavouriteJsonb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentProfiles",
                table: "studentProfiles");

            migrationBuilder.DropColumn(
                name: "StudentFavourite_StudentId",
                table: "studentProfiles");

            migrationBuilder.DropColumn(
                name: "StudentFavourite_TeacherId",
                table: "studentProfiles");

            migrationBuilder.RenameTable(
                name: "studentProfiles",
                newName: "studentProfile");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "studentProfile",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "studentFavourite",
                table: "studentProfile",
                type: "jsonb",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentProfile",
                table: "studentProfile",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentProfile",
                table: "studentProfile");

            migrationBuilder.DropColumn(
                name: "studentFavourite",
                table: "studentProfile");

            migrationBuilder.RenameTable(
                name: "studentProfile",
                newName: "studentProfiles");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "studentProfiles",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "StudentFavourite_StudentId",
                table: "studentProfiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentFavourite_TeacherId",
                table: "studentProfiles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentProfiles",
                table: "studentProfiles",
                column: "Id");
        }
    }
}
