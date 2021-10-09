using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyensVases.Data;
using NguyensVases.Models;

namespace NguyensVases.Controllers
{
    public class VasesController : Controller
    {
        private readonly NguyensVasesContext _context;

        public VasesController(NguyensVasesContext context)
        {
            _context = context;
        }

        // GET: Vases
        public async Task<IActionResult> Index(string vasesMaterial, string searchString)
        {
            // using the LINQ to get the list of materials
            IQueryable<string> materialQuery = from v in _context.Vases
                                               orderby v.Material
                                               select v.Material;
            var vases = from v in _context.Vases
                         select v;
            if (!String.IsNullOrEmpty(searchString))
            {
                vases = vases.Where(s => s.Name.Contains(searchString));
            }
                
            if (!string.IsNullOrEmpty(vasesMaterial))
            {
                vases = vases.Where(x => x.Material == vasesMaterial);
            }

            var vasesMaterialVM = new VasesMaterialViewModel
            {
                Material = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Vases = await vases.ToListAsync()
            };
            return View(vasesMaterialVM);
        }

        // GET: Vases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vases = await _context.Vases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vases == null)
            {
                return NotFound();
            }

            return View(vases);
        }

        // GET: Vases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Material,Color,Weight,Price")] Vases vases)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vases);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vases);
        }

        // GET: Vases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vases = await _context.Vases.FindAsync(id);
            if (vases == null)
            {
                return NotFound();
            }
            return View(vases);
        }

        // POST: Vases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Material,Color,Weight,Price")] Vases vases)
        {
            if (id != vases.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vases);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VasesExists(vases.Id))
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
            return View(vases);
        }

        // GET: Vases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vases = await _context.Vases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vases == null)
            {
                return NotFound();
            }

            return View(vases);
        }

        // POST: Vases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vases = await _context.Vases.FindAsync(id);
            _context.Vases.Remove(vases);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VasesExists(int id)
        {
            return _context.Vases.Any(e => e.Id == id);
        }
    }
}
