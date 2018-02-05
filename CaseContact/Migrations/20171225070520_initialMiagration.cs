using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CaseContact.Migrations
{
    public partial class initialMiagration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "NewContact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AZCaseNumber = table.Column<string>(nullable: true),
                    AcceptedAsClient = table.Column<bool>(nullable: false),
                    ActiveAttorneyEmail = table.Column<string>(maxLength: 40, nullable: true),
                    ActiveAttorneyFirmName = table.Column<string>(maxLength: 40, nullable: true),
                    ActiveAttorneyFirstName = table.Column<string>(maxLength: 40, nullable: true),
                    ActiveAttorneyLastName = table.Column<string>(maxLength: 40, nullable: true),
                    ActiveAttorneyPhoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    AddressCity = table.Column<string>(maxLength: 40, nullable: true),
                    AddressLineOne = table.Column<string>(maxLength: 40, nullable: true),
                    AddressLineThree = table.Column<string>(maxLength: 40, nullable: true),
                    AddressLineTwo = table.Column<string>(maxLength: 40, nullable: true),
                    AddressState = table.Column<string>(maxLength: 2, nullable: true),
                    AddressZip = table.Column<string>(maxLength: 10, nullable: true),
                    AttorneyNotes = table.Column<string>(maxLength: 500, nullable: true),
                    CaseTypeSelected = table.Column<string>(maxLength: 10, nullable: true),
                    ContactCreated = table.Column<DateTime>(nullable: false),
                    CurrentlyHasAnAttorney = table.Column<bool>(nullable: false),
                    DateFiled = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    FeeAgreementDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 40, nullable: true),
                    LastName = table.Column<string>(maxLength: 40, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 40, nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true),
                    OpposingPartyAddressCity = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyAddressLineOne = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyAddressLineThree = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyAddressLineTwo = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyAddressState = table.Column<string>(maxLength: 2, nullable: true),
                    OpposingPartyAddressZip = table.Column<string>(maxLength: 10, nullable: true),
                    OpposingPartyFirstName = table.Column<string>(nullable: true),
                    OpposingPartyHasAttorney = table.Column<bool>(nullable: false),
                    OpposingPartyLastName = table.Column<string>(nullable: true),
                    OpposingPartyMiddleName = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyRepresentedBy = table.Column<string>(maxLength: 40, nullable: true),
                    OpposingPartyTelephoneNumber = table.Column<string>(maxLength: 40, nullable: true),
                    ReadyToSignFeeAgreement = table.Column<bool>(nullable: false),
                    SocialSecurity = table.Column<string>(nullable: true),
                    TelephoneNumber = table.Column<string>(nullable: true),
                    ThirdParty = table.Column<bool>(nullable: false),
                    ThirdPartyPaying = table.Column<bool>(nullable: false),
                    WorkEmail = table.Column<string>(nullable: true),
                    WorkPhoneNumber = table.Column<string>(nullable: true),
                    hasBeenFiled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewContact", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropTable(
                name: "NewContact");
        }
    }
}
