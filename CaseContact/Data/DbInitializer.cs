using CaseContact.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContact.Data
{
    public class DbInitializer
    {
        public static void Initialize(CaseTypeDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.CaseType.Any())
            {
                return;

            }
            if (context.Gender.Any())
            {
                return;

            }

            var caseTypes = new CaseType[]
            {
                new CaseType{ CaseTypeDescription = "SelectCasetype"},
                new CaseType{ CaseTypeDescription = "DissolutionWithChildren" },
                new CaseType { CaseTypeDescription = "DissolutionWithoutChildren" },
                new CaseType { CaseTypeDescription = "LegalSeparationWithChildren" },
                new CaseType { CaseTypeDescription = "LegalSeparationWithoutChildren" },
                new CaseType { CaseTypeDescription = "Third Party Visitation" },
                new CaseType { CaseTypeDescription = "Anullment" },
                new CaseType { CaseTypeDescription = "Paternity" },
                new CaseType { CaseTypeDescription = "Maternity" },
                new CaseType { CaseTypeDescription = "Establish Legal Decision-Making" },
                new CaseType { CaseTypeDescription = "Establish Legal Decision-Making Parenting Time" },
                new CaseType { CaseTypeDescription = "Modify Legal Decision-Making Parenting Time" },
                new CaseType { CaseTypeDescription = "Establish Legal Decision-Making Parenting Time Child Support" },
                new CaseType { CaseTypeDescription = "Modify Legal Decision-Making Parenting Time Child Support" },
                new CaseType { CaseTypeDescription = "Modify Parenting Time" },
                new CaseType { CaseTypeDescription = "Modify Parenting Time" },
                new CaseType { CaseTypeDescription = "Modify Child Support" },
                new CaseType { CaseTypeDescription = "Modify Child Support Simplified" },
                new CaseType { CaseTypeDescription = "Petition To Enforce" },
                new CaseType { CaseTypeDescription = "Petition For Order To Show Cause Contempt" },
                new CaseType { CaseTypeDescription = "Mediation" },
                new CaseType { CaseTypeDescription = "Arbitration" },
                new CaseType { CaseTypeDescription = "Real Estate Special Commissioner" }
            };
            foreach (CaseType caseType in caseTypes)
            {
                context.CaseType.Add(caseType);
            }
            context.SaveChanges();
            var gender = new Gender[]
            {
                new Gender { GenderList = "Select"},
                new Gender { GenderList = "Female"},
                new Gender { GenderList = "Male"},
                new Gender { GenderList = "Transgender"},
                new Gender { GenderList = "Non Binary"}
            };
            foreach (Gender genderType in gender)
            {
                context.Gender.Add(genderType);
            }
            context.SaveChanges();

        }

        public static void InitializeGender(CaseTypeDbContext context)
        {
            context.Database.EnsureCreated();
           
            if (context.Gender.Any())
            {
                return;

            }

            var gender = new Gender[]
            {
                new Gender { GenderList = "Select"},
                new Gender { GenderList = "Female"},
                new Gender { GenderList = "Male"},
                new Gender { GenderList = "Transgender"},
                new Gender { GenderList = "Non Binary"}
            };
            foreach (Gender genderType in gender)
            {
                context.Gender.Add(genderType);
            }
            context.SaveChanges();

        }

        public static void InitializeContactTime(CaseTypeDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.ContactTime.Any())
            {
                return;

            }

            var contactTimes = new ContactTime[]
            {
                new ContactTime { TimeToContact = "Morning"},
                new ContactTime { TimeToContact = "Afternoon"},
                new ContactTime { TimeToContact = "Evening"},
                new ContactTime { TimeToContact = "Night"},
            };
            foreach (ContactTime contactTime in contactTimes)
            {
                context.ContactTime.Add(contactTime);
            }
            context.SaveChanges();

        }
        public static void InitializeContactType(CaseTypeDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.ContactType.Any())
            {
                return;

            }

            var contactTypes = new ContactType[]
            {
                new ContactType { ContactTypeList = "Phone"},
                new ContactType { ContactTypeList = "Email"},
                new ContactType { ContactTypeList = "Leave Voicemail"},
                new ContactType { ContactTypeList = "Text Message"},
            };
            foreach (ContactType contactType in contactTypes)
            {
                context.ContactType.Add(contactType);
            }
            context.SaveChanges();

        }

    }

  
}
