using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaseContactUI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using CaseContactUI.Services;
using CaseContactUI.Data;

namespace CaseContactUI.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailishere;
        private readonly CaseContactUiDbContext _context;
        private readonly INewContactService _newContactService;

        public AppController(IMailService mailService, INewContactService newContactService, CaseContactUiDbContext context)
        {
              _mailishere = mailService;
              _context = context;
             _newContactService = newContactService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewContact()
        {
            var existingContacts = _context.NewContact;

            return View();
        }
        [HttpGet]
        public IActionResult CreateNewContact()
        {
            var existingContacts = _context.NewContact;

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {

            var model = new RegistrationDto();
            SelectListItem selListItem = new SelectListItem() { Value = "1", Text = "Select One" };
            List<SelectListItem> caseTypes = new List<SelectListItem>();
            caseTypes.Add(new SelectListItem() { Text = "Dissolution With Children", Value = "1" });
            caseTypes.Add(new SelectListItem() { Text = "Dissolution Without Children", Value = "2" });
            caseTypes.Add(new SelectListItem() { Text = "Legal Separation" , Value = "3" });

            model.caseTypes = caseTypes;
            //Create a list of select list items - this will be returned as your select list
            List<SelectListItem> newList = new List<SelectListItem>();

            //Add select list item to list of selectlistitems
           
            ViewBag.ListItems = caseTypes;
            //model.CaseTypeListId = model.CaseTypeList.Select(a => a.Value).ToString();

            //model.ClientGender = _newCaseType.CreateGenderList();
            //model.ClientGenderId = model.ClientGender.Select(a => a.Value).ToString();

            //model.OpposingPartyGender = _newCaseType.CreateGenderList();
            //model.OpposingPartyGenderId = model.OpposingPartyGender.Select(a => a.Value).ToString();

            //model.WayToContact = _newCaseType.CreateContactTypeList();
            //model.WayToContactSelected = model.WayToContact.Select(a => a.Value).ToString();

            //var listOfBestTimesContact = _context.ContactTime.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.TimeToContact });
            //model.BestTimeToContact = new SelectList(listOfBestTimesContact, "Id", "Value");
            //model.BestTimeToContactSelected = listOfBestTimesContact.Select(a => a.Value).ToString();

            //var listOfThirdPartyGender = _context.Gender.OrderBy(t => t.Id).Select(x => new { Id = x.Id, Value = x.GenderList });
            //model.ThirdPartyGender = new SelectList(listOfThirdPartyGender, "Id", "Value");
            //model.ThirdPartyGenderId = listOfThirdPartyGender.Select(a => a.Value).ToString();

            //return View(model);
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegistrationDto model)
        {
            ViewBag.Title = "Please Register";

            if (ModelState.IsValid)
            {
                _mailishere.SendMessage("lenags@gmail.com", model.EmailSubject = "Subject", $"From: {model.FirstName} - {model.EmailSubject = "Subject"}, Message: {model.Message="Message"}");

            }
          
            return View();

        }
    }
}