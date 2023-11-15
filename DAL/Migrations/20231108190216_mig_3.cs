using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DerslikTeacher",
                columns: table => new
                {
                    DersliklerDerslikId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeachersTeacherId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslikTeacher", x => new { x.DersliklerDerslikId, x.TeachersTeacherId });
                    table.ForeignKey(
                        name: "FK_DerslikTeacher_Derslikler_DersliklerDerslikId",
                        column: x => x.DersliklerDerslikId,
                        principalTable: "Derslikler",
                        principalColumn: "DerslikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DerslikTeacher_Teachers_TeachersTeacherId",
                        column: x => x.TeachersTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DerslikTeacher_TeachersTeacherId",
                table: "DerslikTeacher",
                column: "TeachersTeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DerslikTeacher");
        }
    }
}
