using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class NewContactGender_AddGenderToview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientGender",
                table: "NewContact",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpposingPartyGender",
                table: "NewContact",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdPartyGender",
                table: "NewContact",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenderList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropColumn(
                name: "ClientGender",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "OpposingPartyGender",
                table: "NewContact");

            migrationBuilder.DropColumn(
                name: "ThirdPartyGender",
                table: "NewContact");
        }
    }
}
