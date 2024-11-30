using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebFerreteria.Models;

namespace WebFerreteria.Controllers
{
    public class VentaDetalleController : Controller
    {
        private readonly FinalFerreteriaContext _context;

        public VentaDetalleController(FinalFerreteriaContext context)
        {
            _context = context;
        }

        // GET: VentaDetalles
        public async Task<IActionResult> Index()
        {
            var finalFerreteriaContext = _context.VentaDetalles.Include(v => v.IdProductoNavigation).Include(v => v.IdVentaNavigation);
            return View(await finalFerreteriaContext.ToListAsync());
        }

        // GET: VentaDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventaDetalle = await _context.VentaDetalles
                .Include(v => v.IdProductoNavigation)
                .Include(v => v.IdVentaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }

            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id");
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id");
            return View();
        }

        // POST: VentaDetalles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdVenta,IdProducto,NombreProducto,PrecioUnitario,Cantidad,Subtotal,UsuarioRegistro,FechaRegistro,Estado")] VentaDetalle ventaDetalle)
        {
            // Buscar el producto en la base de datos
            var producto = await _context.Productos.FindAsync(ventaDetalle.IdProducto);
            if (producto == null)
            {
                ModelState.AddModelError("", "El producto seleccionado no existe.");
                ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Descripcion", ventaDetalle.IdProducto);
                ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
                return View(ventaDetalle);
            }

            // Asignar la descripción del producto al campo NombreProducto
            ventaDetalle.NombreProducto = producto.Descripcion;

            if (!String.IsNullOrEmpty(ventaDetalle.NombreProducto) && ventaDetalle.PrecioUnitario >= 0 && ventaDetalle.Cantidad >= 0)
            {
                ventaDetalle.UsuarioRegistro = User.Identity.Name;
                ventaDetalle.FechaRegistro = DateTime.Now;
                _context.Add(ventaDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Descripcion", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }
            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Id", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // POST: VentaDetalles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdVenta,IdProducto,NombreProducto,PrecioUnitario,Cantidad,Subtotal,UsuarioRegistro,FechaRegistro,Estado")] VentaDetalle ventaDetalle)
        {
            if (id != ventaDetalle.Id)
            {
                return NotFound();
            }

            // Buscar el producto en la base de datos
            var producto = await _context.Productos.FindAsync(ventaDetalle.IdProducto);
            if (producto == null)
            {
                ModelState.AddModelError("", "El producto seleccionado no existe.");
                ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Descripcion", ventaDetalle.IdProducto);
                ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
                return View(ventaDetalle);
            }

            // Asignar la descripción del producto al campo NombreProducto
            ventaDetalle.NombreProducto = producto.Descripcion;

            if (!String.IsNullOrEmpty(ventaDetalle.NombreProducto) && ventaDetalle.PrecioUnitario >= 0 && ventaDetalle.Cantidad >= 0)
            {
                try
                {
                    _context.Update(ventaDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentaDetalleExists(ventaDetalle.Id))
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

            ViewData["IdProducto"] = new SelectList(_context.Productos, "Id", "Descripcion", ventaDetalle.IdProducto);
            ViewData["IdVenta"] = new SelectList(_context.Venta, "Id", "Id", ventaDetalle.IdVenta);
            return View(ventaDetalle);
        }

        // GET: VentaDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ventaDetalle = await _context.VentaDetalles
                        .Include(v => v.IdProductoNavigation)
                        .Include(v => v.IdVentaNavigation)
                        .FirstOrDefaultAsync(m => m.Id == id);
            if (ventaDetalle == null)
            {
                return NotFound();
            }

            return View(ventaDetalle);

        }
        // POST: VentaDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ventaDetalle = await _context.VentaDetalles.FindAsync(id);
            if (ventaDetalle != null)
            {
                _context.VentaDetalles.Remove(ventaDetalle);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VentaDetalleExists(int id)
        {
            return _context.VentaDetalles.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> GetPrecioProducto(int idProducto)
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(p => p.Id == idProducto);
            if (producto == null)
            {
                return NotFound();
            }

            return Json(new
            {
                precioProducto = producto.PrecioVenta,
                nombreProducto = producto.Descripcion,
                marcaProducto = producto.Marca,
                codigoProducto = producto.Codigo,
                stockProducto = producto.Stock,
                unidadmedidaProducto = producto.UnidadMedida

            });
        }


    }
}
