using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class ContactInfo
    {
        public Guid Id { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TelephoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [MaxLength(40)]
        public string FacebookAccount { get; set; }
        [MaxLength(40)]
        public string TwitterAccount { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string MobileNumber { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public NewContact NewContact { get; set; }
        public OpposingParty OpposingParty { get; set; }       
       

    }
}
