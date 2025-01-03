﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebFerreteria.Models;

namespace WebFerreteria.Controllers
{
    public class VentasController : Controller
    {
        private readonly FinalFerreteriaContext _context;

        public VentasController(FinalFerreteriaContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var finalFerreteriaContext = _context.Venta.Include(v => v.IdClienteNavigation).Include(v => v.IdUsuarioNavigation);
            return View(await finalFerreteriaContext.ToListAsync());
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id");
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdUsuario,IdCliente,Total,MontoPago,MontoCambio")] Venta venta)
        {

            if (venta.MontoPago > 0 && venta.Total > 0 && venta.MontoCambio >= 0)
            {
                venta.UsuarioRegistro = User.Identity.Name;
                venta.FechaRegistro = DateTime.Now;
                venta.Estado = 1;
                _context.Add(venta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }



            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", venta.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", venta.IdUsuario);
            return View(venta);
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", venta.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", venta.IdUsuario);
            return View(venta);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUsuario,IdCliente,Total,MontoPago,MontoCambio,Fecha,UsuarioRegistro,FechaRegistro,Estado")] Venta venta)
        {
            if (id != venta.Id)
            {
                return NotFound();
            }

            if (venta.Total >= 0 && venta.MontoPago >= 0 && venta.MontoCambio >= 0)
            {
                try
                {
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaExists(venta.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", venta.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", venta.IdUsuario);
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Venta
                .Include(v => v.IdClienteNavigation)
                .Include(v => v.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var venta = await _context.Venta.FindAsync(id);
            if (venta != null)
            {
                _context.Venta.Remove(venta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaExists(int id)
        {
            return _context.Venta.Any(e => e.Id == id);
        }
    }
}
