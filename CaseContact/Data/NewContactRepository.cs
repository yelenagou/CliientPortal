using CaseContact.Models;
using CaseContact.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CaseContact.Data
{
    public class NewContactRepository

    {
        private readonly CaseTypeDbContext _context;
        public NewContactRepository(CaseTypeDbContext context)
        {
            _context = context;
        }

        public List<NewContact> GetListOfNewContacts()
        {


            var listOfContacts = this._context.NewContact.ToList();

            if (listOfContacts.Equals(null))
            {
                throw new HttpRequestException();
            }

            return listOfContacts.ToList();
        }
    }
}
