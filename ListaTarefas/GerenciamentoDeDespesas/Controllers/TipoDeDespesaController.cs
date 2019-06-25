using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciamentoDeDespesas.Data;
using GerenciamentoDeDespesas.Dto;

namespace GerenciamentoDeDespesas.Controllers
{
    public class TipoDeDespesaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoDeDespesaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TipoDeDespesa
        public async Task<IActionResult> Index()
        {
            var dados = await _context.TipoDeDespesas.ToListAsync();
            return View(dados);
        }

   

        // GET: TipoDeDespesa/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TipoDeDespesaId,Nome")] TipoDeDespesaDto tipoDeDespesaDto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoDeDespesaDto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoDeDespesaDto);
        }

        // GET: TipoDeDespesa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeDespesaDto = await _context.TipoDeDespesaDto.FindAsync(id);
            if (tipoDeDespesaDto == null)
            {
                return NotFound();
            }
            return View(tipoDeDespesaDto);
        }

        // POST: TipoDeDespesa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TipoDeDespesaId,Nome")] TipoDeDespesaDto tipoDeDespesaDto)
        {
            if (id != tipoDeDespesaDto.TipoDeDespesaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoDeDespesaDto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoDeDespesaDtoExists(tipoDeDespesaDto.TipoDeDespesaId))
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
            return View(tipoDeDespesaDto);
        }

        // GET: TipoDeDespesa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoDeDespesaDto = await _context.TipoDeDespesaDto
                .FirstOrDefaultAsync(m => m.TipoDeDespesaId == id);
            if (tipoDeDespesaDto == null)
            {
                return NotFound();
            }

            return View(tipoDeDespesaDto);
        }

        // POST: TipoDeDespesa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoDeDespesaDto = await _context.TipoDeDespesaDto.FindAsync(id);
            _context.TipoDeDespesaDto.Remove(tipoDeDespesaDto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoDeDespesaDtoExists(int id)
        {
            return _context.TipoDeDespesaDto.Any(e => e.TipoDeDespesaId == id);
        }
    }
}
