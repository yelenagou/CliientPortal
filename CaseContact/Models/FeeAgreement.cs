using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContact.Models
{
    public class FeeAgreement
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime CreditCardExpirationDate { get; set; }
        public int CVVCode { get; set; }
        public string CCBillingAddressLineOne { get; set; }
        public string CCBillingAddressLineTwo { get; set; }
        public string CCBillingAddressCity { get; set; }
        public string CCBillingAddressState { get; set; }
        public byte[] CardHolderSignature { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public DateTime BirthYear { get; set; }
        public int LastFourOfSocial { get; set; }
        public string CreditCardTypeId { get; set; }
        public string AhAddressLineOne { get; set; }
        public string AhCCBillingAddressLineTwo { get; set; }
        public string AhBillingAddressCity { get; set; }
        public string AhBillingAddressState { get; set; }
        public byte[] AccountHolderSignature { get; set; }
        public DateTime DateSigned { get; set; }
        //public DriverLicense DriverLicense { get; set; }
    }
}
