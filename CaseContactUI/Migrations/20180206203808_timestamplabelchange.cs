using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContactUI.Migrations
{
    public partial class timestamplabelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RowVersion",
                table: "ThirdParty",
                newName: "TpRowVersion");

            migrationBuilder.RenameColumn(
                name: "RowVersion",
                table: "NewContact",
                newName: "NewContactRowVersion");

            migrationBuilder.AddColumn<byte[]>(
                name: "OppPartyRowVersion",
                table: "OpposingParty",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OppPartyRowVersion",
                table: "OpposingParty");

            migrationBuilder.RenameColumn(
                name: "TpRowVersion",
                table: "ThirdParty",
                newName: "RowVersion");

            migrationBuilder.RenameColumn(
                name: "NewContactRowVersion",
                table: "NewContact",
                newName: "RowVersion");
        }
    }
}
