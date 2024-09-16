using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class isassigned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAssigned",
                table: "Cihazs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAssigned",
                table: "Cihazs");
        }
    }
}
