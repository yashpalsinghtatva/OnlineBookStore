using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStoreAPI.Migrations
{
    public partial class BookChangeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberofPages",
                table: "Books",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "Books",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberofPages",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "Books");
        }
    }
}
