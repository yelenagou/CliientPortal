using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseContactUI.Services
{
    public interface INewContactService
    {
        SelectList CreateCaseTypeList();
        SelectList CreateGenderList();
        SelectList CreateContactTypeList();
        SelectList CreateBestTimeToContactList();

    }
}
