using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace issueTracker.Migrations
{
    public partial class AddColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Statuses",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Priorities",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Creators",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Categories",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Priorities");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Creators");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categories");
        }
    }
}
