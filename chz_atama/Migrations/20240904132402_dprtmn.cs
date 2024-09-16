using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class dprtmn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmanID",
                table: "CihazAtamas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CihazAtamas_DepartmanID",
                table: "CihazAtamas",
                column: "DepartmanID");

            migrationBuilder.AddForeignKey(
                name: "FK_CihazAtamas_Departmans_DepartmanID",
                table: "CihazAtamas",
                column: "DepartmanID",
                principalTable: "Departmans",
                principalColumn: "DepartmanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CihazAtamas_Departmans_DepartmanID",
                table: "CihazAtamas");

            migrationBuilder.DropIndex(
                name: "IX_CihazAtamas_DepartmanID",
                table: "CihazAtamas");

            migrationBuilder.DropColumn(
                name: "DepartmanID",
                table: "CihazAtamas");
        }
    }
}
