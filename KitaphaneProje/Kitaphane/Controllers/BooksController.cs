using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kitaphane.Data;
using Kitaphane.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kitaphane.Controllers
{
    public class BooksController : Controller
    {
        private readonly KitaphaneContext _context;

        public BooksController(KitaphaneContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index()
        {
            var kitaphaneContext = _context.Books.Include(b => b.Author).Include(b => b.Publisher);
            return View(await kitaphaneContext.ToListAsync());
        }


        [AllowAnonymous]
        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [Authorize(Roles = "adminez")]
        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorName"] = new SelectList(_context.Author, "Name", "Name");
            ViewData["PublisherName"] = new SelectList(_context.Publisher, "Name", "Name");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,PublisherName,AuthorName,Description,Price,Stock,Year,imageURL")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AuthorName"] = new SelectList(_context.Author, "Name", "Name", book.AuthorName);
            ViewData["PublisherName"] = new SelectList(_context.Publisher, "Name", "Name", book.PublisherName);
            return View(book);
        }

        [Authorize(Roles = "adminez")]
        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["AuthorName"] = new SelectList(_context.Author, "Name", "Name", book.AuthorName);
            ViewData["PublisherName"] = new SelectList(_context.Publisher, "Name", "Name", book.PublisherName);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,PublisherName,AuthorName,Description,Price,Stock,Year,imageURL")] Book book)
        {
            if (id != book.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.ID))
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
            ViewData["AuthorName"] = new SelectList(_context.Author, "Name", "Name", book.AuthorName);
            ViewData["PublisherName"] = new SelectList(_context.Publisher, "Name", "Name", book.PublisherName);
            return View(book);
        }

        [Authorize(Roles = "adminez")]
        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.ID == id);
        }

    }
}
