using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class CartDishesController : Controller
    {
        private readonly Context _context;

        public CartDishesController(Context context)
        {
            _context = context;
        }

        // GET: CartDishes
        public async Task<IActionResult> Index()
        {
              return _context.CartDishes != null ? 
                          View(await _context.CartDishes.ToListAsync()) :
                          Problem("Entity set 'Context.CartDish'  is null.");
        }

        // GET: CartDishes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CartDishes == null)
            {
                return NotFound();
            }

            var cartDish = await _context.CartDishes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartDish == null)
            {
                return NotFound();
            }

            return View(cartDish);
        }

        // GET: CartDishes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartDishes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity")] CartDish cartDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartDish);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartDish);
        }

        // GET: CartDishes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CartDishes == null)
            {
                return NotFound();
            }

            var cartDish = await _context.CartDishes.FindAsync(id);
            if (cartDish == null)
            {
                return NotFound();
            }
            return View(cartDish);
        }

        // POST: CartDishes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity")] CartDish cartDish)
        {
            if (id != cartDish.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartDish);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartDishExists(cartDish.Id))
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
            return View(cartDish);
        }

        // GET: CartDishes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CartDishes == null)
            {
                return NotFound();
            }

            var cartDish = await _context.CartDishes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartDish == null)
            {
                return NotFound();
            }

            return View(cartDish);
        }

        // POST: CartDishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CartDishes == null)
            {
                return Problem("Entity set 'Context.CartDish'  is null.");
            }
            var cartDish = await _context.CartDishes.FindAsync(id);
            if (cartDish != null)
            {
                _context.CartDishes.Remove(cartDish);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartDishExists(int id)
        {
          return (_context.CartDishes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
