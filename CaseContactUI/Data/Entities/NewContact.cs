using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class NewContact
    {
        public Guid Id { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(14)]
        public string SocialSecurity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ReasonForContacting { get; set; }
        public string TelephoneNumber { get; set; }
        public bool? InquiringForSomeoneElse { get; set; }
        public bool? ReadyForRegistration { get; set; }
        public bool? HaveSomethingFileWithCourt { get; set; }
        public ThirdParty ThirdPartyInfo {get;set;}
        public ICollection<ContactInfo> ContactInfo { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateOfNewContact { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Attorney> PreviousAttorney { get; set; }
        public OpposingParty OpposingParty { get; set; }

    }
    
}
