using CaseContact.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContact.Services
{
    public interface INewCaseType
    {
        Task<List<CaseType>> GetListOfCaseTypes();
        Task<List<ContactType>> GetListOfContactTypes();
        void UpdateCaseType(CaseType caseType);
        SelectList CreateCaseTypeList();
        SelectList CreateGenderList();
        SelectList CreateContactTypeList();
        SelectList CreateBestTimeToContactList();
        Task<CaseType> EditCaseType(int id);

    }
}
