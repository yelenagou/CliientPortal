using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class typeofcontact_timeToContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BestTimeToContact",
                table: "NewContact",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BestWayToContact",
                table: "NewContact",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContactTime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeToContact = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactTypeList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactTime");

            migrationBuilder.DropTable(
                name: "ContactType");

            migrationBuilder.DropColumn(
                name: "BestTimeToContact",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "BestWayToContact",
                table: "NewContact");
        }
    }
}
