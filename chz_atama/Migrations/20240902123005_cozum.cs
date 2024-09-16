using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class cozum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "DepartmanId",
                table: "Personels",
                newName: "DepartmanID");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels",
                newName: "IX_Personels_DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_DepartmanID",
                table: "Personels",
                column: "DepartmanID",
                principalTable: "Departmans",
                principalColumn: "DepartmanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_DepartmanID",
                table: "Personels");

            migrationBuilder.RenameColumn(
                name: "DepartmanID",
                table: "Personels",
                newName: "DepartmanId");

            migrationBuilder.RenameIndex(
                name: "IX_Personels_DepartmanID",
                table: "Personels",
                newName: "IX_Personels_DepartmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels",
                column: "DepartmanId",
                principalTable: "Departmans",
                principalColumn: "DepartmanID");
        }
    }
}
