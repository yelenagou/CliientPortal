using CaseContact.Data;
using CaseContact.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContact.ViewComponents
{
    public class ContactTypeList : ViewComponent
    {
        private readonly CaseTypeDbContext _context;
        private readonly INewCaseType _caseType;
        public ContactTypeList(CaseTypeDbContext context, INewCaseType caseType)
        {
            _context = context;
            _caseType = caseType;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _caseType.GetListOfContactTypes();
            return View(await items);
        }
    }
}
