using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace issueTracker.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name,Color) values('CRM','#ff00ff')");
            migrationBuilder.Sql("Insert into Categories(Name,Color) values('Azure','#00ffff')");
            migrationBuilder.Sql("Insert into Categories(Name,Color) values('SharePoint','#ffff00')");


            migrationBuilder.Sql("Insert into Priorities(Name,Color) values('High','#ff00ff')");
            migrationBuilder.Sql("Insert into Priorities(Name,Color) values('Low','#00ffff')");
            migrationBuilder.Sql("Insert into Priorities(Name,Color) values('Medium','#ffff00')");

            migrationBuilder.Sql("Insert into Statuses(Name,Color) values('Closed','#ff00ff')");
            migrationBuilder.Sql("Insert into Statuses(Name,Color) values('Open','#00ffff')");
            migrationBuilder.Sql("Insert into Statuses(Name,Color) values('Paused By Client','#ffff00')");
            migrationBuilder.Sql("Insert into Statuses(Name,Color) values('Paused By Developer','#ffff00')");
            migrationBuilder.Sql("Insert into Statuses(Name,Color) values('Clarification Needed','#ffff00')");

            migrationBuilder.Sql("Insert into Creators(Name,Color) values('XRMLabs','#ffff00')");
            migrationBuilder.Sql("Insert into Creators(Name,Color) values('Solomon Coyle','#ffff00')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From Statuses");
            migrationBuilder.Sql("Delete From Creators");
            migrationBuilder.Sql("Delete From Categories");
            migrationBuilder.Sql("Delete From Priorities");
        }
    }
}
