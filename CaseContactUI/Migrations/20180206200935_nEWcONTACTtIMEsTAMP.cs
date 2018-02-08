using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContactUI.Migrations
{
    public partial class nEWcONTACTtIMEsTAMP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfNewContact",
                table: "NewContact");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "NewContact",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "NewContact");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfNewContact",
                table: "NewContact",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
