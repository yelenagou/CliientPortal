using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseContactUI.ViewModels
{
    public class NewContactDbo
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
        public ThirdPartyDto ThirdPartyInfo { get; set; }
        public ICollection<ContactInfoDbo> ContactInfo { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateOfNewContact { get; set; }
        public ICollection<AddressDbo> Address { get; set; }
        public ICollection<AttorneyDbo> PreviousAttorney { get; set; }
        public OpposingPartyDto OpposingParty { get; set; }
    }
}
