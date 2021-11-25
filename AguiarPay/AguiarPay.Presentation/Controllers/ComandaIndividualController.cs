using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AguiarPay.Business.Models;
using AguiarPay.Data.Context;

namespace AguiarPay.Presentation.Controllers
{
    public class ComandaIndividualController : Controller
    {
        private readonly AguiarDbContext _context;

        public ComandaIndividualController(AguiarDbContext context)
        {
            _context = context;
        }

        // GET: ComandaIndividual
        public async Task<IActionResult> Index()
        {
            return View(await _context.ComandasIndividuais.ToListAsync());
        }

        // GET: ComandaIndividual/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comandaIndividual = await _context.ComandasIndividuais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comandaIndividual == null)
            {
                return NotFound();
            }

            return View(comandaIndividual);
        }

        // GET: ComandaIndividual/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ComandaIndividual/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] ComandaIndividual comandaIndividual)
        {
            if (ModelState.IsValid)
            {
                comandaIndividual.Id = Guid.NewGuid();
                _context.Add(comandaIndividual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(comandaIndividual);
        }

        // GET: ComandaIndividual/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comandaIndividual = await _context.ComandasIndividuais.FindAsync(id);
            if (comandaIndividual == null)
            {
                return NotFound();
            }
            return View(comandaIndividual);
        }

        // POST: ComandaIndividual/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id")] ComandaIndividual comandaIndividual)
        {
            if (id != comandaIndividual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comandaIndividual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComandaIndividualExists(comandaIndividual.Id))
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
            return View(comandaIndividual);
        }

        // GET: ComandaIndividual/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comandaIndividual = await _context.ComandasIndividuais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comandaIndividual == null)
            {
                return NotFound();
            }

            return View(comandaIndividual);
        }

        // POST: ComandaIndividual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var comandaIndividual = await _context.ComandasIndividuais.FindAsync(id);
            _context.ComandasIndividuais.Remove(comandaIndividual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComandaIndividualExists(Guid id)
        {
            return _context.ComandasIndividuais.Any(e => e.Id == id);
        }
    }
}
