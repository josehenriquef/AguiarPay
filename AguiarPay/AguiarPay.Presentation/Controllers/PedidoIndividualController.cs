using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AguiarPay.Business.Models;
using AguiarPay.Data.Context;

namespace AguiarPay.Presentation.ViewModels
{
    public class PedidoIndividualController : Controller
    {
        private readonly AguiarDbContext _context;

        public PedidoIndividualController(AguiarDbContext context)
        {
            _context = context;
        }

        // GET: PedidoIndividual
        public async Task<IActionResult> Index()
        {
            var aguiarDbContext = _context.PedidosIndividuais.Include(p => p.ComandaIndividual).Include(p => p.Produto);
            return View(await aguiarDbContext.ToListAsync());
        }

        // GET: PedidoIndividual/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoIndividual = await _context.PedidosIndividuais
                .Include(p => p.ComandaIndividual)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoIndividual == null)
            {
                return NotFound();
            }

            return View(pedidoIndividual);
        }

        // GET: PedidoIndividual/Create
        public IActionResult Create()
        {
            ViewData["ComandaIndividualId"] = new SelectList(_context.ComandasIndividuais, "Id", "Id");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao");
            return View();
        }

        // POST: PedidoIndividual/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ComandaIndividualId,ProdutoId,Id")] PedidoIndividual pedidoIndividual)
        {
            if (ModelState.IsValid)
            {
                pedidoIndividual.Id = Guid.NewGuid();
                _context.Add(pedidoIndividual);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ComandaIndividualId"] = new SelectList(_context.ComandasIndividuais, "Id", "Id", pedidoIndividual.ComandaIndividualId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao", pedidoIndividual.ProdutoId);
            return View(pedidoIndividual);
        }

        // GET: PedidoIndividual/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoIndividual = await _context.PedidosIndividuais.FindAsync(id);
            if (pedidoIndividual == null)
            {
                return NotFound();
            }
            ViewData["ComandaIndividualId"] = new SelectList(_context.ComandasIndividuais, "Id", "Id", pedidoIndividual.ComandaIndividualId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao", pedidoIndividual.ProdutoId);
            return View(pedidoIndividual);
        }

        // POST: PedidoIndividual/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ComandaIndividualId,ProdutoId,Id")] PedidoIndividual pedidoIndividual)
        {
            if (id != pedidoIndividual.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoIndividual);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoIndividualExists(pedidoIndividual.Id))
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
            ViewData["ComandaIndividualId"] = new SelectList(_context.ComandasIndividuais, "Id", "Id", pedidoIndividual.ComandaIndividualId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "Id", "Descricao", pedidoIndividual.ProdutoId);
            return View(pedidoIndividual);
        }

        // GET: PedidoIndividual/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoIndividual = await _context.PedidosIndividuais
                .Include(p => p.ComandaIndividual)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidoIndividual == null)
            {
                return NotFound();
            }

            return View(pedidoIndividual);
        }

        // POST: PedidoIndividual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pedidoIndividual = await _context.PedidosIndividuais.FindAsync(id);
            _context.PedidosIndividuais.Remove(pedidoIndividual);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoIndividualExists(Guid id)
        {
            return _context.PedidosIndividuais.Any(e => e.Id == id);
        }
    }
}
