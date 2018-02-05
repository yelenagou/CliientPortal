using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContactUI.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewContact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DateOfNewContact = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: true),
                    HaveSomethingFileWithCourt = table.Column<bool>(nullable: true),
                    InquiringForSomeoneElse = table.Column<bool>(nullable: true),
                    LastName = table.Column<string>(maxLength: 40, nullable: true),
                    ReadyForRegistration = table.Column<bool>(nullable: true),
                    ReasonForContacting = table.Column<string>(nullable: true),
                    SocialSecurity = table.Column<string>(maxLength: 14, nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewContact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpposingParty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: true),
                    LastName = table.Column<string>(maxLength: 40, nullable: true),
                    SocialSecurity = table.Column<string>(maxLength: 14, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpposingParty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OpposingParty_NewContact_Id",
                        column: x => x.Id,
                        principalTable: "NewContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThirdParty",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddessLineTwo = table.Column<string>(maxLength: 40, nullable: true),
                    Address = table.Column<string>(maxLength: 40, nullable: true),
                    BestTimeToContact = table.Column<string>(nullable: true),
                    BestWayToContact = table.Column<string>(nullable: true),
                    DateInserted = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(maxLength: 40, nullable: true),
                    LastName = table.Column<string>(maxLength: 40, nullable: true),
                    NewContactId = table.Column<Guid>(nullable: false),
                    ReasonForContacting = table.Column<string>(maxLength: 50, nullable: false),
                    SocialSecurity = table.Column<string>(maxLength: 14, nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: false),
                    ThirdPartyNotes = table.Column<string>(maxLength: 300, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdParty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThirdParty_NewContact_Id",
                        column: x => x.Id,
                        principalTable: "NewContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressLineOne = table.Column<string>(maxLength: 40, nullable: true),
                    AddressLineTwo = table.Column<string>(maxLength: 30, nullable: true),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    DateInserted = table.Column<DateTime>(nullable: false),
                    NewContactId = table.Column<Guid>(nullable: true),
                    OpposingPartyId = table.Column<Guid>(nullable: true),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_NewContact_NewContactId",
                        column: x => x.NewContactId,
                        principalTable: "NewContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Address_OpposingParty_OpposingPartyId",
                        column: x => x.OpposingPartyId,
                        principalTable: "OpposingParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attorney",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateAttorneyHired = table.Column<DateTime>(nullable: true),
                    DateFinishedworking = table.Column<DateTime>(nullable: true),
                    FirmName = table.Column<string>(maxLength: 40, nullable: true),
                    FirstName = table.Column<string>(maxLength: 40, nullable: true),
                    LastName = table.Column<string>(maxLength: 40, nullable: true),
                    NewContactId = table.Column<Guid>(nullable: true),
                    OpposingPartyId = table.Column<Guid>(nullable: true),
                    requestMade = table.Column<bool>(nullable: true),
                    stillWorking = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attorney", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attorney_NewContact_NewContactId",
                        column: x => x.NewContactId,
                        principalTable: "NewContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attorney_OpposingParty_OpposingPartyId",
                        column: x => x.OpposingPartyId,
                        principalTable: "OpposingParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateOfContactInfo = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FacebookAccount = table.Column<string>(maxLength: 40, nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    NewContactId = table.Column<Guid>(nullable: true),
                    OpposingPartyId = table.Column<Guid>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    TwitterAccount = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfo_NewContact_NewContactId",
                        column: x => x.NewContactId,
                        principalTable: "NewContact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactInfo_OpposingParty_OpposingPartyId",
                        column: x => x.OpposingPartyId,
                        principalTable: "OpposingParty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_NewContactId",
                table: "Address",
                column: "NewContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_OpposingPartyId",
                table: "Address",
                column: "OpposingPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Attorney_NewContactId",
                table: "Attorney",
                column: "NewContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Attorney_OpposingPartyId",
                table: "Attorney",
                column: "OpposingPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_NewContactId",
                table: "ContactInfo",
                column: "NewContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfo_OpposingPartyId",
                table: "ContactInfo",
                column: "OpposingPartyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Attorney");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "ThirdParty");

            migrationBuilder.DropTable(
                name: "OpposingParty");

            migrationBuilder.DropTable(
                name: "NewContact");
        }
    }
}
