using CaseContact.Models;
using CaseContact.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CaseContact.Data
{
    public class NewCaseTypeRepository : INewCaseType
    {
        private readonly CaseTypeDbContext _context;
        public NewCaseTypeRepository(CaseTypeDbContext context)
        {
            _context = context;
        }
       public Task<List<CaseType>> GetListOfCaseTypes()
        {
            var listOfContacts = this._context.CaseType;

            if (listOfContacts.Equals(null))
            {
                throw new HttpRequestException();
            }

            return  listOfContacts.ToListAsync();
        }
        public Task<CaseType> EditCaseType(int id)
        {
            var caseType = this._context.CaseType.Where(c => c.Id == id).FirstOrDefaultAsync();


            if (caseType.Equals(null))
            {
                throw new HttpRequestException();
            }

            return caseType;
        }
        public Task<List<ContactType>> GetListOfContactTypes()
        {
            var listOfContactTypes = this._context.ContactType;

            if (listOfContactTypes.Equals(null))
            {
                throw new HttpRequestException();
            }

            return listOfContactTypes.ToListAsync();
        }
        public  void UpdateCaseType(CaseType caseType)
        {
            _context.SaveChanges();
        }

      public  async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public SelectList CreateCaseTypeList()
        {
            var listOfCaseTypes = _context.CaseType.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.CaseTypeDescription });
            var CaseTypeList = new SelectList(listOfCaseTypes, "Id", "Value");
            return CaseTypeList;
        }
        public SelectList CreateGenderList()
        {
            var listOfGenders = _context.Gender.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.GenderList});
            var GenderList = new SelectList(listOfGenders, "Id", "Value");
            return GenderList;
        }
        public SelectList CreateContactTypeList()
        {
            var listOfContactTypes = _context.ContactType.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.ContactTypeList });
            var ContactTypeList = new SelectList(listOfContactTypes, "Id", "Value");
            return ContactTypeList;
        }
        public SelectList CreateBestTimeToContactList()
        {
            var listOfBestTimesToContact = _context.ContactTime.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.TimeToContact });
            var listBestTImeToContact = new SelectList(listOfBestTimesToContact, "Id", "Value");
            return listBestTImeToContact;
        }
    }
}
