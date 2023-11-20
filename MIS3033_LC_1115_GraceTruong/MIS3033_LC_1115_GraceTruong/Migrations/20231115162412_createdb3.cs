using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_LC_1115_GraceTruong.Migrations
{
    /// <inheritdoc />
    public partial class createdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentID",
                table: "Profiles",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_StudentID",
                table: "Profiles",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_Students_StudentID",
                table: "Profiles",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_Students_StudentID",
                table: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_Profiles_StudentID",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Profiles");
        }
    }
}
