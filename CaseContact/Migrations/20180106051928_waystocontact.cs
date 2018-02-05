using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class waystocontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewContact_FilingInformation_FilingInformationId",
                table: "NewContact");

            migrationBuilder.DropTable(
                name: "FilingInformation");

            migrationBuilder.DropIndex(
                name: "IX_NewContact_FilingInformationId",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "FilingInformationId",
                table: "NewContact");

            migrationBuilder.CreateTable(
                name: "WaysToContact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Definition = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaysToContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaysToContactDbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Definition = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaysToContactDbo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WaysToContact");

            migrationBuilder.DropTable(
                name: "WaysToContactDbo");

            migrationBuilder.AddColumn<int>(
                name: "FilingInformationId",
                table: "NewContact",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FilingInformation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AZSuperiorCourtURI = table.Column<string>(maxLength: 50, nullable: true),
                    AZSuperirorCourtCaseNumber = table.Column<string>(maxLength: 14, nullable: true),
                    DateFiled = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilingInformation", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewContact_FilingInformationId",
                table: "NewContact",
                column: "FilingInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewContact_FilingInformation_FilingInformationId",
                table: "NewContact",
                column: "FilingInformationId",
                principalTable: "FilingInformation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
