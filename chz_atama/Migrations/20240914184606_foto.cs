using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class foto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoğrafYolu",
                table: "Personels",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoğrafYolu",
                table: "Personels");
        }
    }
}
