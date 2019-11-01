using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoExemplo.Data;
using ProjetoExemplo.Dto;
using ProjetoExemplo.Models;

namespace ProjetoExemplo.Controllers
{
    public class ImagemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ImagemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Imagems
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Imagens.Include(i => i.Album);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Imagems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagens
                .Include(i => i.Album)
                .FirstOrDefaultAsync(m => m.ImagemId == id);
            if (imagem == null)
            {
                return NotFound();
            }

            return View(imagem);
        }

        // GET: Imagems/Create
        public IActionResult Create()
        {
            ViewData["AlbumId"] = new SelectList(_context.Albuns, "AlbumId", "Destino");
            return View();
        }

        // POST: Imagems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Imagem imagem)
        {
            if (ModelState.IsValid)
            {
                TempData["confirmacao"] = "Imagem foi cadastrado com sucesso.";
                _context.Add(imagem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlbumId"] = new SelectList(_context.Albuns, "AlbumId", "Destino", imagem.AlbumId);
            return View(imagem);
        }

        // GET: Imagems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagem = await _context.Imagens.FindAsync(id);
            if (imagem == null)
            {
                return NotFound();
            }
            ViewData["AlbumId"] = new SelectList(_context.Albuns, "AlbumId", "Destino", imagem.AlbumId);
            return View(imagem);
        }

        // POST: Imagems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ImagemId,Link,AlbumId")] Imagem imagem)
        {
            if (id != imagem.ImagemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemExists(imagem.ImagemId))
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
            ViewData["AlbumId"] = new SelectList(_context.Albuns, "AlbumId", "Destino", imagem.AlbumId);
            return View(imagem);
        }


        // POST: Albuns/Delete/5
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            var imagem = await _context.Imagens.FindAsync(id);
            _context.Imagens.Remove(imagem);
            await _context.SaveChangesAsync();
            return Json("Imagem excluida com sucesso");
        }


        private bool ImagemExists(int id)
        {
            return _context.Imagens.Any(e => e.ImagemId == id);
        }
    }
}
