﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Models;

namespace ProjetoCinema.Controllers
{
    public class BomboniereController : Controller
    {
        private readonly Contexto _context;

        public BomboniereController(Contexto context)
        {
            _context = context;
        }

        // GET: Bomboniere
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Bomboniere.Include(b => b.Categoria);
            return View(await contexto.ToListAsync());
        }

        // GET: Bomboniere/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bomboniere == null)
            {
                return NotFound();
            }

            var bomboniere = await _context.Bomboniere
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bomboniere == null)
            {
                return NotFound();
            }

            return View(bomboniere);
        }

        // GET: Bomboniere/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaNome");
            return View();
        }

        // POST: Bomboniere/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoriaId,NomeProduto,DescricaoProduto,TamanhoProduto,PrecoProduto")] Bomboniere bomboniere)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bomboniere);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaNome", bomboniere.CategoriaId);
            return View(bomboniere);
        }

        // GET: Bomboniere/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bomboniere == null)
            {
                return NotFound();
            }

            var bomboniere = await _context.Bomboniere.FindAsync(id);
            if (bomboniere == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaNome", bomboniere.CategoriaId);
            return View(bomboniere);
        }

        // POST: Bomboniere/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoriaId,NomeProduto,DescricaoProduto,TamanhoProduto,PrecoProduto")] Bomboniere bomboniere)
        {
            if (id != bomboniere.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bomboniere);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BomboniereExists(bomboniere.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "CategoriaNome", bomboniere.CategoriaId);
            return View(bomboniere);
        }

        // GET: Bomboniere/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bomboniere == null)
            {
                return NotFound();
            }

            var bomboniere = await _context.Bomboniere
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bomboniere == null)
            {
                return NotFound();
            }

            return View(bomboniere);
        }

        // POST: Bomboniere/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bomboniere == null)
            {
                return Problem("Entity set 'Contexto.Bomboniere'  is null.");
            }
            var bomboniere = await _context.Bomboniere.FindAsync(id);
            if (bomboniere != null)
            {
                _context.Bomboniere.Remove(bomboniere);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BomboniereExists(int id)
        {
          return (_context.Bomboniere?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
