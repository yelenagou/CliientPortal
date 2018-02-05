using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class UpdateNewContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.RenameColumn(
                name: "AZCaseNumber",
                table: "NewContact",
                newName: "AzSuperiroCourtURI");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFiled",
                table: "NewContact",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "AZSuperiorCourtCaseNumber",
                table: "NewContact",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AZSuperiorCourtCaseNumber",
                table: "NewContact");

            migrationBuilder.RenameColumn(
                name: "AzSuperiroCourtURI",
                table: "NewContact",
                newName: "AZCaseNumber");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFiled",
                table: "NewContact",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

           
        }
    }
}
