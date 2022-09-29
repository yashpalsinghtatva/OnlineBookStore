﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBookStoreAPI.Migrations
{
    public partial class BookImageFieldAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookImagePath",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookImagePath",
                table: "Books");
        }
    }
}
