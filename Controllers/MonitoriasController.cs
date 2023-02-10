using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MonitoriaAgentes.Data;
using MonitoriaAgentes.Models;

namespace MonitoriaAgentes.Controllers
{
    public class MonitoriasController : Controller
    {
        private readonly MonitoriaAgentesContext _context;

        public MonitoriasController(MonitoriaAgentesContext context)
        {
            _context = context;
        }

        // GET: Monitorias
        public async Task<IActionResult> Index()
        {
              return View(await _context.Monitoria.ToListAsync());
        }

        // GET: Monitorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Monitoria == null)
            {
                return NotFound();
            }

            var monitoria = await _context.Monitoria
                .FirstOrDefaultAsync(m => m.MonitoriaId == id);
            if (monitoria == null)
            {
                return NotFound();
            }

            return View(monitoria);
        }

        // GET: Monitorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Monitorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MonitoriaId,Assunto,DataDaMonitoria,NomeAgente,MatriculaAgente,AD_Agente,NomeSupervisor,Descricao")] Monitoria monitoria)
        {
            if (ModelState.IsValid)
            {
                _context.Add(monitoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(monitoria);
        }

        // GET: Monitorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Monitoria == null)
            {
                return NotFound();
            }

            var monitoria = await _context.Monitoria.FindAsync(id);
            if (monitoria == null)
            {
                return NotFound();
            }
            return View(monitoria);
        }

        // POST: Monitorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MonitoriaId,Assunto,DataDaMonitoria,NomeAgente,MatriculaAgente,AD_Agente,NomeSupervisor,Descricao")] Monitoria monitoria)
        {
            if (id != monitoria.MonitoriaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(monitoria);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MonitoriaExists(monitoria.MonitoriaId))
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
            return View(monitoria);
        }

        // GET: Monitorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Monitoria == null)
            {
                return NotFound();
            }

            var monitoria = await _context.Monitoria
                .FirstOrDefaultAsync(m => m.MonitoriaId == id);
            if (monitoria == null)
            {
                return NotFound();
            }

            return View(monitoria);
        }

        // POST: Monitorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Monitoria == null)
            {
                return Problem("Entity set 'MonitoriaAgentesContext.Monitoria'  is null.");
            }
            var monitoria = await _context.Monitoria.FindAsync(id);
            if (monitoria != null)
            {
                _context.Monitoria.Remove(monitoria);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MonitoriaExists(int id)
        {
          return _context.Monitoria.Any(e => e.MonitoriaId == id);
        }
    }
}
