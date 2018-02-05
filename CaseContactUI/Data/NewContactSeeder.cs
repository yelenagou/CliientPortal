using CaseContactUI.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseContactUI.Data
{
    public class NewContactSeeder
    {
        private readonly CaseContactUiDbContext _context;
        private readonly IHostingEnvironment _hosting;
        public NewContactSeeder(CaseContactUiDbContext context, IHostingEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }
        public DateTime DateOfBirthOutput { get; set; }
        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (!_context.NewContact.Any())
            {
                var newContactout = new NewContact()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Eliza",
                    LastName = "Walker",
                    DateOfBirth = new DateTime(1976, 10, 12),
                    HaveSomethingFileWithCourt = false,
                    InquiringForSomeoneElse = false,
                    ReadyForRegistration = false,
                    ReasonForContacting = "",
                    SocialSecurity = "888-00-8899",
                    TelephoneNumber = "480-363-8899",
                    Address = new List<Address>()


                };
                //var filePath = Path.Combine(_hosting.ContentRootPath,"/Data/art.json");
                //var json = File.ReadAllText(filePath);
                //var newContacts = JsonConvert.DeserializeObject<IEnumerable<NewContact>>(json);
                //_context.NewContact.AddRange(newContacts);
            }
           
        }
    }
}
