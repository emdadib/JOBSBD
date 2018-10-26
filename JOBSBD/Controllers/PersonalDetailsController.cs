using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JOBSBD.Data;
using JOBSBD.Models;

namespace JOBSBD.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly JOBSBDContext _context;

        public PersonalDetailsController(JOBSBDContext context)
        {
            _context = context;
        }

        // GET: PersonalDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonalDetail.ToListAsync());
        }

        // GET: PersonalDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetail
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }

        // GET: PersonalDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonalID,FullName,FathersName,MothersName,DateOfBirth,Religion,Nationality,MaritalStatus,UserPicture")] PersonalDetail personalDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personalDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personalDetail);
        }

        // GET: PersonalDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetail.FindAsync(id);
            if (personalDetail == null)
            {
                return NotFound();
            }
            return View(personalDetail);
        }

        // POST: PersonalDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonalID,FullName,FathersName,MothersName,DateOfBirth,Religion,Nationality,MaritalStatus,UserPicture")] PersonalDetail personalDetail)
        {
            if (id != personalDetail.PersonalID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalDetailExists(personalDetail.PersonalID))
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
            return View(personalDetail);
        }

        // GET: PersonalDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetail
                .FirstOrDefaultAsync(m => m.PersonalID == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }

        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalDetail = await _context.PersonalDetail.FindAsync(id);
            _context.PersonalDetail.Remove(personalDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalDetailExists(int id)
        {
            return _context.PersonalDetail.Any(e => e.PersonalID == id);
        }
    }
}
