using CaseContactUI.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Services
{
    public class NewContactService : INewContactService
    {
        private readonly CaseContactUiDbContext _context;
        public NewContactService(CaseContactUiDbContext context)
        {
            _context = context;
        }

        public SelectList CreateCaseTypeList()
        {
            var listOfCaseTypes = _context.ListCaseTypes.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.CaseTypeDescription });
            var CaseTypeList = new SelectList(listOfCaseTypes, "Id", "Value");
            return CaseTypeList;
        }
        public SelectList CreateGenderList()
        {
            var listOfGenders = _context.ListGender.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.GenderValue});
            var GenderList = new SelectList(listOfGenders, "Id", "Value");
            return GenderList;
        }
        public SelectList CreateContactTypeList()
        {
            var listOfContactTypes = _context.ListWaysToContact.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.WaysToContactValue });
            var ContactTypeList = new SelectList(listOfContactTypes, "Id", "Value");
            return ContactTypeList;
        }
        public SelectList CreateBestTimeToContactList()
        {
            var listOfBestTimesToContact = _context.ListBestTimeToContact.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.BestTimeToContactValue });
            var listBestTImeToContact = new SelectList(listOfBestTimesToContact, "Id", "Value");
            return listBestTImeToContact;
        }
    }
}
