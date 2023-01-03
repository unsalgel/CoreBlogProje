using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccesLayer.Migrations
{
    public partial class iliskisil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_WriterUserId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterUserId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterUserId",
                table: "Blogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterUserId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterUserId",
                table: "Blogs",
                column: "WriterUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_WriterUserId",
                table: "Blogs",
                column: "WriterUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
