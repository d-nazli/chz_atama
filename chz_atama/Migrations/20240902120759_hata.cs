using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class hata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanId",
                table: "Personels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels",
                column: "DepartmanId",
                principalTable: "Departmans",
                principalColumn: "DepartmanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmanId",
                table: "Personels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmans_DepartmanId",
                table: "Personels",
                column: "DepartmanId",
                principalTable: "Departmans",
                principalColumn: "DepartmanID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
