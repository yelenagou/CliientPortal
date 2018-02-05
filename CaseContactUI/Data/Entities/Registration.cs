using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entiti

{
    public class Registration
    {
        public Registration()
        {


            List <SelectListItem> caseTypes = new List<SelectListItem>() { new SelectListItem { Value = null, Text = " " } };
            CaseTypeList = new SelectList(caseTypes, "Value", "Text");
          
        
        }
        

        
        
        public Guid Id { get; set; }
        public SelectList CaseTypeList { get; set; }

        public bool hasBeenFiled { get; set; }
        public string AZSuperiorCourtCaseNumber { get; set; }
        public DateTime? DateFiled { get; set; }
        [MaxLength(40)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(40)]
        public string MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string ClientGender { get; set; }
        public string WorkPhoneNumber { get; set; }
        [MaxLength(20)]
        public string BestTimeToContact { get; set; }
        [MaxLength(20)]
        public string BestWayToContact { get; set; }
        public string WorkEmail { get; set; }
        [MaxLength(40)]
        public string AddressLineOne { get; set; }
        [MaxLength(40)]
        public string AddressLineTwo { get; set; }
        [MaxLength(40)]
        public string AddressLineThree { get; set; }
        [MaxLength(40)]
        public string AddressCity { get; set; }
        [MaxLength(2)]
        public string AddressState { get; set; }
        [MaxLength(10)]
        public string AddressZip { get; set; }
        public string TelephoneNumber { get; set; }
        [MaxLength(10)]
        public string CaseTypeSelected { get; set; }
        //Other Party Information
        public string OpposingPartyFirstName { get; set; }
        public string OpposingPartyLastName { get; set; }
        [MaxLength(40)]
        public string OpposingPartyMiddleName { get; set; }
        [MaxLength(40)]
        public string OpposingPartyAddressLineOne { get; set; }
        [MaxLength(20)]
        public string OpposingPartyGender { get; set; }
        [MaxLength(40)]
        public string OpposingPartyAddressLineTwo { get; set; }
        [MaxLength(40)]
        public string OpposingPartyAddressLineThree { get; set; }
        [MaxLength(40)]
        public string OpposingPartyAddressCity { get; set; }
        [MaxLength(2)]
        public string OpposingPartyAddressState { get; set; }
        [MaxLength(10)]
        public string OpposingPartyAddressZip { get; set; }
        [MaxLength(40)]
        public string OpposingPartyTelephoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string OpposingPartyEmailAddress { get; set; }
        public bool OpposingPartyHasAttorney { get; set; }
        [MaxLength(40)]
        public string OpposingPartyRepresentedBy { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string OpposingPartyAttorneyPhoneNumber { get; set; }
        //Acitve Attorney Information
        public bool CurrentlyHasAnAttorney { get; set; }
        [MaxLength(40)]
        public string ActiveAttorneyFirstName { get; set; }
        [MaxLength(40)]
        public string ActiveAttorneyLastName { get; set; }
        [MaxLength(40)]
        public string ActiveAttorneyFirmName { get; set; }
        [MaxLength(20)]
        public string ActiveAttorneyPhoneNumber { get; set; }
        [MaxLength(40)]
        public string ActiveAttorneyEmail { get; set; }
        public bool AcceptedAsClient { get; set; }
        public bool ReadyToSignFeeAgreement { get; set; }
        public DateTime FeeAgreementDate { get; set; }
        public bool ThirdParty { get; set; }
        public bool ThirdPartyPaying { get; set; }
        [MaxLength(20)]
        public string ThirdPartyGender { get; set; }
        [MaxLength(40)]
        public string ThirdPartyFirstName { get; set; }
        [MaxLength(40)]
        public string ThirdPartyLastName { get; set; }
        [MaxLength(40)]
        public string ThirdPartyEmailAddress { get; set; }
        [MaxLength(20)]
        public string ThirdPartyPhoneNumber { get; set; }
        public string ThirdPartyAddress { get; set; }
        public string ThirdPartyAddressLineTwo { get; set; }
        public string ThirdPartyCity { get; set; }
        public string ThirdPartyState { get; set; }
        public string thirdPartyZip { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }
        [MaxLength(500)]
        public string AttorneyNotes { get; set; }
        public DateTime ContactCreated { get; set; } = DateTime.Now;
        public string AzSuperiroCourtURI
        {
            get; set;
        }
    }
}
