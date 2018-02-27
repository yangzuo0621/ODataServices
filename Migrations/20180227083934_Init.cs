﻿using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CsvToolDb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ReportBack = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    SubmittedDate = table.Column<DateTime>(nullable: true),
                    TaskSLADate = table.Column<DateTime>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
