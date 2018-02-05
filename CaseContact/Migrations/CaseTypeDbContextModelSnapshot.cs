﻿// <auto-generated />
using CaseContact.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CaseContact.Migrations
{
    [DbContext(typeof(CaseTypeDbContext))]
    partial class CaseTypeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CaseContact.Models.CaseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CaseTypeDescription");

                    b.HasKey("Id");

                    b.ToTable("CaseType");
                });

            modelBuilder.Entity("CaseContact.Models.ContactTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TimeToContact");

                    b.HasKey("Id");

                    b.ToTable("ContactTime");
                });

            modelBuilder.Entity("CaseContact.Models.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactTypeList");

                    b.HasKey("Id");

                    b.ToTable("ContactType");
                });

            modelBuilder.Entity("CaseContact.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenderList");

                    b.HasKey("Id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("CaseContact.Models.NewContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AZSuperiorCourtCaseNumber");

                    b.Property<bool>("AcceptedAsClient");

                    b.Property<string>("ActiveAttorneyEmail")
                        .HasMaxLength(40);

                    b.Property<string>("ActiveAttorneyFirmName")
                        .HasMaxLength(40);

                    b.Property<string>("ActiveAttorneyFirstName")
                        .HasMaxLength(40);

                    b.Property<string>("ActiveAttorneyLastName")
                        .HasMaxLength(40);

                    b.Property<string>("ActiveAttorneyPhoneNumber")
                        .HasMaxLength(20);

                    b.Property<string>("AddressCity")
                        .HasMaxLength(40);

                    b.Property<string>("AddressLineOne")
                        .HasMaxLength(40);

                    b.Property<string>("AddressLineThree")
                        .HasMaxLength(40);

                    b.Property<string>("AddressLineTwo")
                        .HasMaxLength(40);

                    b.Property<string>("AddressState")
                        .HasMaxLength(2);

                    b.Property<string>("AddressZip")
                        .HasMaxLength(10);

                    b.Property<string>("AttorneyNotes")
                        .HasMaxLength(500);

                    b.Property<string>("AzSuperiroCourtURI");

                    b.Property<string>("BestTimeToContact")
                        .HasMaxLength(20);

                    b.Property<string>("BestWayToContact")
                        .HasMaxLength(20);

                    b.Property<string>("CaseTypeSelected")
                        .HasMaxLength(10);

                    b.Property<string>("ClientGender");

                    b.Property<DateTime>("ContactCreated");

                    b.Property<bool>("CurrentlyHasAnAttorney");

                    b.Property<DateTime?>("DateFiled");

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<DateTime>("FeeAgreementDate");

                    b.Property<string>("FirstName")
                        .HasMaxLength(40);

                    b.Property<string>("LastName")
                        .HasMaxLength(40);

                    b.Property<string>("MiddleName")
                        .HasMaxLength(40);

                    b.Property<string>("Notes")
                        .HasMaxLength(500);

                    b.Property<string>("OpposingPartyAddressCity")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyAddressLineOne")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyAddressLineThree")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyAddressLineTwo")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyAddressState")
                        .HasMaxLength(2);

                    b.Property<string>("OpposingPartyAddressZip")
                        .HasMaxLength(10);

                    b.Property<string>("OpposingPartyAttorneyPhoneNumber");

                    b.Property<string>("OpposingPartyEmailAddress");

                    b.Property<string>("OpposingPartyFirstName");

                    b.Property<string>("OpposingPartyGender")
                        .HasMaxLength(20);

                    b.Property<bool>("OpposingPartyHasAttorney");

                    b.Property<string>("OpposingPartyLastName");

                    b.Property<string>("OpposingPartyMiddleName")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyRepresentedBy")
                        .HasMaxLength(40);

                    b.Property<string>("OpposingPartyTelephoneNumber")
                        .HasMaxLength(40);

                    b.Property<bool>("ReadyToSignFeeAgreement");

                    b.Property<string>("SocialSecurity");

                    b.Property<string>("TelephoneNumber");

                    b.Property<bool>("ThirdParty");

                    b.Property<string>("ThirdPartyEmailAddress")
                        .HasMaxLength(40);

                    b.Property<string>("ThirdPartyFirstName")
                        .HasMaxLength(40);

                    b.Property<string>("ThirdPartyGender")
                        .HasMaxLength(20);

                    b.Property<string>("ThirdPartyLastName")
                        .HasMaxLength(40);

                    b.Property<bool>("ThirdPartyPaying");

                    b.Property<string>("ThirdPartyPhoneNumber")
                        .HasMaxLength(20);

                    b.Property<string>("WorkEmail");

                    b.Property<string>("WorkPhoneNumber");

                    b.Property<bool>("hasBeenFiled");

                    b.HasKey("Id");

                    b.ToTable("NewContact");
                });

            modelBuilder.Entity("CaseContact.Models.WaysToContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Definition");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("WaysToContact");
                });
#pragma warning restore 612, 618
        }
    }
}
