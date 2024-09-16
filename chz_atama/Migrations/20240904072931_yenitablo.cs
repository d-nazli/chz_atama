using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class yenitablo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeviceStatusViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceStatusViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceStatusViewModels_Cihazs_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazs",
                        principalColumn: "CihazId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeviceStatusViewModels_CihazId",
                table: "DeviceStatusViewModels",
                column: "CihazId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeviceStatusViewModels");
        }
    }
}
