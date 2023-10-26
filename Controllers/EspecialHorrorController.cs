using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

namespace ProjetoCinema.Controllers
{
    public class EspecialHorrorController : Controller
    {
        private readonly Contexto _context;

        public EspecialHorrorController(Contexto context)
        {
            _context = context;
        }

        // GET: EspecialHorror
        public async Task<IActionResult> Index()
        {
              return _context.EspecialHorror != null ? 
                          View(await _context.EspecialHorror.ToListAsync()) :
                          Problem("Entity set 'Contexto.EspecialHorror'  is null.");
        }

        // GET: EspecialHorror/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EspecialHorror == null)
            {
                return NotFound();
            }

            var especialHorror = await _context.EspecialHorror
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialHorror == null)
            {
                return NotFound();
            }

            return View(especialHorror);
        }

        // GET: EspecialHorror/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EspecialHorror/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Filmes,Classificacao,HrSesssao")] EspecialHorror especialHorror)
        {
            if (ModelState.IsValid)
            {
                _context.Add(especialHorror);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(especialHorror);
        }

        // GET: EspecialHorror/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EspecialHorror == null)
            {
                return NotFound();
            }

            var especialHorror = await _context.EspecialHorror.FindAsync(id);
            if (especialHorror == null)
            {
                return NotFound();
            }
            return View(especialHorror);
        }

        // POST: EspecialHorror/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Filmes,Classificacao,HrSesssao")] EspecialHorror especialHorror)
        {
            if (id != especialHorror.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(especialHorror);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspecialHorrorExists(especialHorror.Id))
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
            return View(especialHorror);
        }

        // GET: EspecialHorror/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EspecialHorror == null)
            {
                return NotFound();
            }

            var especialHorror = await _context.EspecialHorror
                .FirstOrDefaultAsync(m => m.Id == id);
            if (especialHorror == null)
            {
                return NotFound();
            }

            return View(especialHorror);
        }

        // POST: EspecialHorror/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EspecialHorror == null)
            {
                return Problem("Entity set 'Contexto.EspecialHorror'  is null.");
            }
            var especialHorror = await _context.EspecialHorror.FindAsync(id);
            if (especialHorror != null)
            {
                _context.EspecialHorror.Remove(especialHorror);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspecialHorrorExists(int id)
        {
          return (_context.EspecialHorror?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
