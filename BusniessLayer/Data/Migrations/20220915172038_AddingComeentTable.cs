using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusniessLayer.Data.Migrations
{
    public partial class AddingComeentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
             name: "Comment",
             columns: table => new
             {
                 Commentid = table.Column<int>(nullable: false)
                     .Annotation("SqlServer:Identity", "1, 1"),
                 CommentText = table.Column<string>(nullable: true),
                 dateTime = table.Column<DateTime>(nullable: false),
                 ProjectId = table.Column<int>(nullable: true)
             },
             constraints: table =>
             {
                 table.PrimaryKey("PK_Comment", x => x.Commentid);
                 table.ForeignKey(
                     name: "FK_Comment_projects_ProjectId",
                     column: x => x.ProjectId,
                     principalTable: "projects",
                     principalColumn: "ProjectId",
                     onDelete: ReferentialAction.Restrict);
             });
            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProjectId",
                table: "Comment",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");
        }
    }
}