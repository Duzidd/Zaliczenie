using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Zaliczenie.Models.domain;
using Zaliczenie.data;

namespace Zaliczenie.Controllers
{
    public class userrs : Controller
    {
        private readonly KolDbcontext _context;

        public userrs(KolDbcontext context)
        {
            _context = context;
        }

        // GET: userrs
        public async Task<IActionResult> Index()
        {
              return _context.userr != null ? 
                          View(await _context.userr.ToListAsync()) :
                          Problem("Entity set 'KolDbcontext.userr'  is null.");
        }

        // GET: userrs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.userr == null)
            {
                return NotFound();
            }

            var userr = await _context.userr
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userr == null)
            {
                return NotFound();
            }

            return View(userr);
        }

        // GET: userrs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: userrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Secondname,Adres,Telefon,Pesel,Osiemnascie,Opiekun,Tel_opiekuna,Od,Do,TypWycieczki")] userr userr)
        {
            if (ModelState.IsValid)
            {
                userr.Id = Guid.NewGuid();
                _context.Add(userr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userr);
        }

        // GET: userrs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.userr == null)
            {
                return NotFound();
            }

            var userr = await _context.userr.FindAsync(id);
            if (userr == null)
            {
                return NotFound();
            }
            return View(userr);
        }

        // POST: userrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Secondname,Adres,Telefon,Pesel,Osiemnascie,Opiekun,Tel_opiekuna,Od,Do,TypWycieczki")] userr userr)
        {
            if (id != userr.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!userrExists(userr.Id))
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
            return View(userr);
        }

        // GET: userrs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.userr == null)
            {
                return NotFound();
            }

            var userr = await _context.userr
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userr == null)
            {
                return NotFound();
            }

            return View(userr);
        }

        // POST: userrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.userr == null)
            {
                return Problem("Entity set 'KolDbcontext.userr'  is null.");
            }
            var userr = await _context.userr.FindAsync(id);
            if (userr != null)
            {
                _context.userr.Remove(userr);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool userrExists(Guid id)
        {
          return (_context.userr?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
