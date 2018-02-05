using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class NewContactDtoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilingInformationId",
                table: "NewContact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpposingPartyAttorneyPhoneNumber",
                table: "NewContact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpposingPartyEmailAddress",
                table: "NewContact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPartyEmailAddress",
                table: "NewContact",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPartyFirstName",
                table: "NewContact",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPartyLastName",
                table: "NewContact",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPartyPhoneNumber",
                table: "NewContact",
                maxLength: 20,
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "OpposingPartyAttorneyPhoneNumber",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "OpposingPartyEmailAddress",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "ThirdPartyEmailAddress",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "ThirdPartyFirstName",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "ThirdPartyLastName",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "ThirdPartyPhoneNumber",
                table: "NewContact");
        }
    }
}
