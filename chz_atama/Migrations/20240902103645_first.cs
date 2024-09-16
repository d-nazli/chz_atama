using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace chz_atama.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cihazs",
                columns: table => new
                {
                    CihazId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CihazAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CihazSeriNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cihazs", x => x.CihazId);
                });

            migrationBuilder.CreateTable(
                name: "Departmans",
                columns: table => new
                {
                    DepartmanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmans", x => x.DepartmanID);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmanId = table.Column<int>(type: "int", nullable: false),
                    PersonelEposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonelTel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personels_Departmans_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmans",
                        principalColumn: "DepartmanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CihazAtamas",
                columns: table => new
                {
                    AtamaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    CihazId = table.Column<int>(type: "int", nullable: false),
                    AtamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CihazAtamas", x => x.AtamaId);
                    table.ForeignKey(
                        name: "FK_CihazAtamas_Cihazs_CihazId",
                        column: x => x.CihazId,
                        principalTable: "Cihazs",
                        principalColumn: "CihazId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CihazAtamas_Personels_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personels",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CihazAtamas_CihazId",
                table: "CihazAtamas",
                column: "CihazId");

            migrationBuilder.CreateIndex(
                name: "IX_CihazAtamas_PersonelId",
                table: "CihazAtamas",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels",
                column: "DepartmanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CihazAtamas");

            migrationBuilder.DropTable(
                name: "Cihazs");

            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Departmans");
        }
    }
}
