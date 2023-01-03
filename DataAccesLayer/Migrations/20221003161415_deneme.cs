using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ilcelers");

            migrationBuilder.DropTable(
                name: "illers");

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "illers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sehir = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_illers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ilcelers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    illrid = table.Column<int>(type: "int", nullable: true),
                    sehir = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilcelers", x => x.id);
                    table.ForeignKey(
                        name: "FK_ilcelers_illers_illrid",
                        column: x => x.illrid,
                        principalTable: "illers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ilcelers_illrid",
                table: "ilcelers",
                column: "illrid");
        }
    }
}
