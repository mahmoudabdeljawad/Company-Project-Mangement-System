using Microsoft.EntityFrameworkCore.Migrations;

namespace BusniessLayer.Data.Migrations
{
    public partial class Relationcomment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberId",
                table: "Comment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_MemberId",
                table: "Comment",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_MemberId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Comment");
        }
    }
}
