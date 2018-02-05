using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaseContact.Data;
using CaseContact.Models;
using CaseContact.ViewModels;
using CaseContact.Services;
using AutoMapper;

namespace CaseContact.Controllers
{
    public class NewContactsController : Controller
    {
        private readonly CaseTypeDbContext _context;
        private readonly INewCaseType _newCaseType;
        private readonly IMapper _mapper; 

        public NewContactsController(CaseTypeDbContext context, INewCaseType newCaseType, IMapper mapper)
        {
            _context = context;
            _newCaseType = newCaseType;
            _mapper = mapper;
        }

        // GET: NewContacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewContact.ToListAsync());
        }

        // GET: NewContacts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newContact = await _context.NewContact
                .SingleOrDefaultAsync(m => m.Id == id);
            if (newContact == null)
            {
                return NotFound();
            }

            return View(newContact);
        }

        // GET: NewContacts/Create
        public async Task<IActionResult> Create()
        {
            var model = new NewContactDbo();
            model.CaseTypeList = _newCaseType.CreateCaseTypeList();
            model.CaseTypeListId = model.CaseTypeList.Select(a => a.Value).ToString();

            model.ClientGender = _newCaseType.CreateGenderList();
            model.ClientGenderId = model.ClientGender.Select(a => a.Value).ToString();

            model.OpposingPartyGender = _newCaseType.CreateGenderList();
            model.OpposingPartyGenderId = model.OpposingPartyGender.Select(a => a.Value).ToString();

            model.WayToContact = _newCaseType.CreateContactTypeList();
            model.WayToContactSelected = model.WayToContact.Select(a => a.Value).ToString();

            var listOfBestTimesContact = _context.ContactTime.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.TimeToContact });
            model.BestTimeToContact = new SelectList(listOfBestTimesContact, "Id", "Value");
            model.BestTimeToContactSelected = listOfBestTimesContact.Select(a => a.Value).ToString();

            var listOfThirdPartyGender = _context.Gender.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.GenderList });
            model.ThirdPartyGender = new SelectList(listOfThirdPartyGender, "Id", "Value");
            model.ThirdPartyGenderId = listOfThirdPartyGender.Select(a => a.Value).ToString();

            return View(model);
        }

        // POST: NewContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewContactDbo model)
        {
            List<CaseType> listCaseTypes = new List<CaseType>();
            if (ModelState.IsValid)
            {
                var mappedFields = _mapper.Map<NewContact>(model);
                mappedFields.CaseTypeSelected = model.CaseTypeListId;


                NewContact newContactModel = new NewContact();
                newContactModel.Id = Guid.NewGuid();
                newContactModel.LastName = model.NewContactInfo.LastName;
                newContactModel.FirstName = model.NewContactInfo.FirstName;
                newContactModel.CaseTypeSelected = model.CaseTypeListId;
                newContactModel.ClientGender = model.ClientGenderId;
                newContactModel.DateOfBirth = model.NewContactInfo.DateOfBirth;
                newContactModel.OpposingPartyFirstName = model.OpposingPartyInformation.FirstName;
                newContactModel.OpposingPartyLastName = model.OpposingPartyInformation.LastName;
                newContactModel.OpposingPartyTelephoneNumber = model.OpposingPartyInformation.TelephoneNumber;
                newContactModel.OpposingPartyGender = model.OpposingPartyGenderId;
                newContactModel.BestWayToContact = model.WayToContactSelected;
                newContactModel.BestTimeToContact = model.BestTimeToContactSelected;
                newContactModel.WorkPhoneNumber = model.WorkInformation.TelephoneNumber;
                newContactModel.WorkEmail = model.WorkInformation.EmailAddress;
                newContactModel.TelephoneNumber = model.NewContactInfo.TelephoneNumber;
                newContactModel.hasBeenFiled = model.hasBeenFiled;
                newContactModel.AZSuperiorCourtCaseNumber = model.AZCaseNumber;
                newContactModel.Notes = model.Notes;
                newContactModel.ThirdPartyGender = model.ThirdPartyGenderId;
                newContactModel.ThirdPartyPaying = model.ThirdPartyPaying;
                newContactModel.ThirdPartyFirstName = model.ThirdPartyInformation.FirstName;
                newContactModel.ThirdPartyLastName = model.ThirdPartyInformation.LastName;
                newContactModel.ThirdPartyEmailAddress = model.ThirdPartyInformation.EmailAddress;
                newContactModel.ThirdPartyPhoneNumber = model.ThirdPartyInformation.TelephoneNumber;
                newContactModel.ThirdPartyPaying = model.ThirdPartyPaying;
                newContactModel.AddressZip = model.NewContaactAddress.AddressZip;
                newContactModel.AddressState = model.NewContaactAddress.AddressState;
                newContactModel.AddressLineTwo = model.NewContaactAddress.AddressLineTwo;
                newContactModel.DateFiled = model.FilingInformation.DateFiled;
                newContactModel.AZSuperiorCourtCaseNumber = model.FilingInformation.AZSuperirorCourtCaseNumber;
                newContactModel.AzSuperiroCourtURI = @"http://www.superiorcourt.maricopa.gov/docket/FamilyCourtCases/caseInfo.asp?caseNumber=" + model.FilingInformation.AZSuperirorCourtCaseNumber;

                newContactModel.AddressLineOne = model.NewContaactAddress.AddressLineOne;
                newContactModel.AddressCity = model.NewContaactAddress.AddressCity;


                _context.Add(newContactModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("Index", "NewContacts");
        }

        // GET: NewContacts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newContact = await _context.NewContact.SingleOrDefaultAsync(m => m.Id == id);
            if (newContact == null)
            {
                return NotFound();
            }
            return View(newContact);
        }

        // POST: NewContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,MiddleName,AddressLineOne,AddressLineTwo,AddressLineThree,AddressCity,AddressState,AddressZip")] NewContact newContact)
        {
            if (id != newContact.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewContactExists(newContact.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(newContact);
        }

        // GET: NewContacts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newContact = await _context.NewContact
                .SingleOrDefaultAsync(m => m.Id == id);
            if (newContact == null)
            {
                return NotFound();
            }

            return View(newContact);
        }

        // POST: NewContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var newContact = await _context.NewContact.SingleOrDefaultAsync(m => m.Id == id);
            _context.NewContact.Remove(newContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewContactExists(Guid id)
        {
            return _context.NewContact.Any(e => e.Id == id);
        }
    }
}
