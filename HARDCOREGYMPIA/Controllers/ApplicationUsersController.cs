using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HARDCOREGYMPIA.Models.dbModels;

namespace HARDCOREGYMPIA.Controllers
{
    public class ApplicationUsersController : Controller
    {
        private readonly HARDCOREGYMContext _context;

        public ApplicationUsersController(HARDCOREGYMContext context)
        {
            _context = context;
        }

        // GET: ApplicationUsers
        public async Task<IActionResult> Usuarios()
        {
            var hARDCOREGYMContext = _context.Users.Include(a => a.IdplanNavigation);
            return View(await hARDCOREGYMContext.ToListAsync());
        }

        // GET: ApplicationUsers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .Include(a => a.IdplanNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // GET: ApplicationUsers/Create
        public IActionResult Create()
        {
            ViewData["Idplan"] = new SelectList(_context.Plans, "Idplan", "Idplan");
            return View();
        }

        // POST: ApplicationUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nombre,Apellido,Idplan,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Usuarios));
            }
            ViewData["Idplan"] = new SelectList(_context.Plans, "Idplan", "Idplan", applicationUser.Idplan);
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }
            ViewData["Idplan"] = new SelectList(_context.Plans, "Idplan", "Idplan", applicationUser.Idplan);
            return View(applicationUser);
        }

        // POST: ApplicationUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nombre,Apellido,Idplan,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationUserExists(applicationUser.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Usuarios));
            }
            ViewData["Idplan"] = new SelectList(_context.Plans, "Idplan", "Idplan", applicationUser.Idplan);
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users == null)
            {
                return NotFound();
            }

            var applicationUser = await _context.Users
                .Include(a => a.IdplanNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return View(applicationUser);
        }

        // POST: ApplicationUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'HARDCOREGYMContext.Users'  is null.");
            }
            var applicationUser = await _context.Users.FindAsync(id);
            if (applicationUser != null)
            {
                _context.Users.Remove(applicationUser);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Usuarios));
        }

        private bool ApplicationUserExists(int id)
        {
          return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
