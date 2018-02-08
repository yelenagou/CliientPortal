using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class OpposingParty
    {
        public Guid Id { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<ContactInfo> ContactInfo { get; set; }
        public NewContact NewContact { get; set; }
        public ICollection<Attorney> CurrentAttorney { get; set; }
        [MaxLength(40)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
        [MaxLength(14)]
        public string SocialSecurity { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Timestamp]
        public byte[] OppPartyRowVersion { get; set; }

    }
}
