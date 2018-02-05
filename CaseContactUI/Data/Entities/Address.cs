using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        [MaxLength(40)]
        public string AddressLineOne { get; set; }
        [MaxLength(30)]
        public string AddressLineTwo { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(10)]
        public string State { get; set; }
        [MaxLength(10)]
        public string ZipCode { get; set; }
       
        public NewContact NewContact { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateInserted { get; set; }
    }
}
