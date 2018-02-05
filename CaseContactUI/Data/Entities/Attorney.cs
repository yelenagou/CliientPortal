using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseContactUI.Data.Entities
{
    public class Attorney
    {
        public Guid Id { get; set; }
        [StringLength(40)]
        public string FirstName { get; set; }
        [StringLength(40)]
        public string LastName { get; set; }
        [StringLength(40)]
        public string FirmName { get; set; }
        public DateTime? DateAttorneyHired { get; set; }
        public DateTime? DateFinishedworking { get; set; }
        public bool? stillWorking { get; set; }
        public bool? requestMade { get; set; }
        public NewContact NewContact { get; set; }
        public OpposingParty OpposingParty { get; set; }

    }
  
}
