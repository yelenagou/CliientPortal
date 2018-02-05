using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaseContact.Data;
using CaseContact.Models;
using CaseContact.Services;

namespace CaseContact.Controllers
{
    public class CaseTypeController : Controller
    {
        private readonly CaseTypeDbContext _context;
        private readonly INewCaseType _caseType;


        public CaseTypeController(CaseTypeDbContext context, INewCaseType caseType)
        {
            _context = context;
            _caseType = caseType;
        }

        // GET: CaseType
        public async Task<IActionResult> Index()
        {
            //var listOfCaseType = _caseType.GetListOfCaseTypes();
            //return View(await listOfCaseType);
            return RedirectToAction(nameof(Create));

        }

        // GET: CaseType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseType = await _context.CaseType
                .SingleOrDefaultAsync(m => m.Id == id);
            if (caseType == null)
            {
                return NotFound();
            }

            return View(caseType);
        }

        // GET: CaseType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaseType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CaseTypeDescription")] CaseType caseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caseType);
                await _context.SaveChangesAsync();
                caseType.CaseTypeDescription = null;
                return RedirectToAction(nameof(Index));
            }
            return View(caseType);
        }

        // GET: CaseType/   /5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseType = await _context.CaseType.SingleOrDefaultAsync(m => m.Id == id);
            if (caseType == null)
            {
                return NotFound();
            }
            return View(caseType);
        }

        // POST: CaseType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CaseTypeDescription")] CaseType caseType)
        {
            if (id != caseType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaseTypeExists(caseType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Create));
            }
            return View(caseType);
        }

        // GET: CaseType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseType = await _context.CaseType
                .SingleOrDefaultAsync(m => m.Id == id);
            if (caseType == null)
            {
                return NotFound();
            }

            return View(caseType);
        }

        // POST: CaseType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caseType = await _context.CaseType.SingleOrDefaultAsync(m => m.Id == id);
            _context.CaseType.Remove(caseType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }

        private bool CaseTypeExists(int id)
        {
            return _context.CaseType.Any(e => e.Id == id);
        }
    }
}
