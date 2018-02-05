using Microsoft.AspNetCore.Mvc.Rendering;
using NewContactAPI.Data;
using NewContactAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewContactAPI.Services
{
    public class NewContactRepo<T>
    {
        private readonly NewContactDbContext _context;
        public NewContactRepo(NewContactDbContext context)
        {
            _context = context;
        }

       public SelectList CreateCaseTypeList()
        {
            var listOfCaseTypes = _context.CaseType.OrderBy(i => i.Id).Select(x => new { Id = x.Id, Value = x.CaseTypeDescription });
            var CaseTypeList = new SelectList(listOfCaseTypes, "Id", "Value");
            return CaseTypeList;
        }
    }
}
