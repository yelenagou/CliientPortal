using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class ThirdParty
    {
        public Guid Id { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(14)]
        public string SocialSecurity { get; set; }
        public string BestTimeToContact { get; set; }
        public string BestWayToContact { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string ReasonForContacting { get; set; }
        [MaxLength(300)]
        public string ThirdPartyNotes { get; set; }
        [MaxLength(40)]
        public string Address { get; set; }
        [MaxLength(40)]
        public string AddessLineTwo { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
        public Guid NewContactId { get; set; }
        [ForeignKey("NewContactId")]
        public NewContact NewContact { get; set; }
        [Timestamp]
        public byte[] TpRowVersion { get; set; }
    }
}
