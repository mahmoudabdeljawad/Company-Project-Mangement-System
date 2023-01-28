using Microsoft.EntityFrameworkCore.Migrations;

namespace BusniessLayer.Data.Migrations
{
    public partial class Commintset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_projects_ProjectId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ProjectId",
                table: "Comments",
                newName: "IX_Comments_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_MemberId",
                table: "Comments",
                newName: "IX_Comments_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Commentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_MemberId",
                table: "Comments",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_projects_ProjectId",
                table: "Comments",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_MemberId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_projects_ProjectId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ProjectId",
                table: "Comment",
                newName: "IX_Comment_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_MemberId",
                table: "Comment",
                newName: "IX_Comment_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Commentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_MemberId",
                table: "Comment",
                column: "MemberId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_projects_ProjectId",
                table: "Comment",
                column: "ProjectId",
                principalTable: "projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
