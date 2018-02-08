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
       
       
        public DateTime DateOfBirthOutput { get; set; }
      
        public static void Seed(CaseContactUiDbContext context)
        {

            context.Database.EnsureCreated();
            if (!context.NewContact.Any())
            {
                var newContactSaved = new NewContact()
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
                    {
                        new Address()
                        {
                             AddressLineOne = "",
                             AddressLineTwo = "",
                             City = "Phoenix",
                             State = "AZ",
                             ZipCode = "85210"
                        }
                    },
                    ContactInfo = new List<ContactInfo>()
                     {
                         new ContactInfo()
                         {
                              EmailAddress = "frank@gmail.com"
                         }
                     },
                    OpposingParty = new OpposingParty()
                    {
                        FirstName = "Holly",
                        LastName = "Ash"
                    }




                };

                context.NewContact.Add(newContactSaved);

                List<string> jsonFiles = new List<string>();
                jsonFiles.Add("Data/Entities/ListJson/newcontact.json");
                jsonFiles.Add("Data/Entities/ListJson/listgender.json");
                jsonFiles.Add("Data/Entities/ListJson/listwaystocontact.json");

                foreach (var jsonFile in jsonFiles)
                {
                    string filePath = GetFilePath(jsonFile);
                    string json = GetJsonString(filePath);
                    var newCaseTypeList = JsonConvert.DeserializeObject<IEnumerable<ListCaseTypes>>(json);

                }
                NewMethod(filePath, json);
                context.ListCaseTypes.AddRange(newCaseTypeList);
                context.SaveChanges();

            }


        }

        private static void NewMethod(string fileName, string json)
        {
            var filePath = GetFilePath(fileName);

             filePath = Path.Combine(Environment.CurrentDirectory, $"{filePath}");
             json = File.ReadAllText(filePath);
            var newCaseTypeList = JsonConvert.DeserializeObject<IEnumerable<ListCaseTypes>>(json);
        }

        private static string GetFilePath(string fileName)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, $"{fileName}");
            return filePath;

        }
        private static string GetJsonString(string filePath)
        {
           string json = File.ReadAllText(filePath);
           return json;
        }
    }
}
