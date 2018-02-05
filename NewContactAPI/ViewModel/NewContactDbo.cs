using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewContactAPI.ViewModel
{
    public class NewContactDbo
    {
        public Guid Id { get; set; }
        public bool hasBeenFiled { get; set; }
        [Display(Name = "Date Filed")]
        public DateTime DateFiled { get; set; }
        [Display(Name = "AZ Family Court Case Number")]
        public string AZCaseNumber { get; set; }
        public ContactDbo NewContactInfo { get; set; }
        [Display(Name = "Client Gender")]
        public SelectList ClientGender { get; set; }
        public SelectList WayToContact { get; set; }
        public string WayToContactSelected { get; set; }
        public SelectList BestTimeToContact { get; set; }
        public string BestTimeToContactSelected { get; set; }
        public string ClientGenderId { get; set; }
        public AddressDbo NewContaactAddress { get; set; }

        public SelectList CaseTypeList { get; set; }
        public string CaseTypeListId { get; set; }
        [Display(Name = "Date Of Birth")]
        public ContactDbo WorkInformation { get; set; }

        public ContactDbo OpposingPartyInformation { get; set; }

        [Display(Name = "Opposisng Party Gender")]
        public SelectList OpposingPartyGender { get; set; }
        public string OpposingPartyGenderId { get; set; }
        public AttorneyDbo OpposingPartyAttorneyInfo { get; set; }
        public bool OpposingPartyHasAttorney { get; set; }
        [MaxLength(40)]
        [Display(Name = "Opposing Party Attorney")]
        public string OpposingPartyRepresentedBy { get; set; }

        //Acitve Attorney Information
        public bool CurrentlyHasAnAttorney { get; set; }
        public AttorneyDbo ActiveAttorneyInformation { get; set; }
        public bool ThirdParty { get; set; }
        public bool ThirdPartyPaying { get; set; }
        [Display(Name = "Third Party Gender")]
        public SelectList ThirdPartyGender { get; set; }
        public string ThirdPartyGenderId { get; set; }
        public ContactDbo ThirdPartyInformation { get; set; }
        public FilingInformationDbo FilingInformation { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }

    }
    public class ContactDbo
    {
        [MaxLength(40)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(40)]
        public string MiddleName { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string TelephoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

    }

    public class AttorneyDbo : ContactDbo
    {
        public string FirmName { get; set; }
        public AddressDbo AttorneyAddress { get; set; }
    }

    public class AddressDbo
    {
        [MaxLength(40)]
        [Display(Name = "Address - Line One")]
        public string AddressLineOne { get; set; }
        [MaxLength(40)]
        [Display(Name = "Address - Line Two")]
        public string AddressLineTwo { get; set; }
        [MaxLength(40)]
        [Display(Name = "City")]
        public string AddressCity { get; set; }
        [MaxLength(3)]
        [Display(Name = "State")]
        public string AddressState { get; set; }
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode, ErrorMessage = "Not a valid Zip Code")]
        [RegularExpression(@"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)", ErrorMessage = "That postal code is not a valid US postal code.")]
        public string AddressZip { get; set; }

    }
    public class FilingInformationDbo
    {

        [MaxLength(14)]
        public string AZSuperirorCourtCaseNumber { get; set; }
        public DateTime? DateFiled { get; set; }
        [MaxLength(50)]
        public string AZSuperiorCourtURI { get; set; }
    }
}
