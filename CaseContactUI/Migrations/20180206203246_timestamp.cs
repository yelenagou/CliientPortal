using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContactUI.Migrations
{
    public partial class timestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateInserted",
                table: "ThirdParty");

            migrationBuilder.DropColumn(
                name: "DateOfContactInfo",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "DateInserted",
                table: "Address");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "ThirdParty",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "ContactInfo",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Address",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "ThirdParty");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "ContactInfo");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Address");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInserted",
                table: "ThirdParty",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfContactInfo",
                table: "ContactInfo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInserted",
                table: "Address",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
