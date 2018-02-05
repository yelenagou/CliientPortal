using CaseContact.Data;
using CaseContact.Models;
using CaseContact.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CaseContact.ViewComponents
{
    public class CaseTypeList : ViewComponent
    {
        private readonly CaseTypeDbContext _context;
        private readonly INewCaseType _caseType;
        public CaseTypeList(CaseTypeDbContext context, INewCaseType caseType)
        {
            _context = context;
            _caseType = caseType;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            CaseType model = new CaseType();
            var items = _caseType.GetListOfCaseTypes();
                        return View(await items);
        }
        
    }
}
