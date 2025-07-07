using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDiti2025.Data;
using AppDiti2025.Models;

namespace AppDiti2025.Controllers;

public class ParentsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ParentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Parents.ToList());
    }

    public IActionResult Details(int? id)
    {
        if (id == null) return NotFound();
        var parent = _context.Parents
            .Include(p => p.Apprenants)
            .FirstOrDefault(p => p.IdPar == id);
        if (parent == null) return NotFound();
        return View(parent);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Statut")] Parent parent)
    {
        if (ModelState.IsValid)
        {
            _context.Parents.Add(parent);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(parent);
    }

    public IActionResult Edit(int? id)
    {
        if (id == null) return NotFound();
        var parent = _context.Parents.Find(id);
        if (parent == null) return NotFound();
        return View(parent);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("IdPar,Statut")] Parent parent)
    {
        if (id != parent.IdPar) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(parent);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(parent);
    }

    public IActionResult Delete(int? id)
    {
        if (id == null) return NotFound();
        var parent = _context.Parents.FirstOrDefault(p => p.IdPar == id);
        if (parent == null) return NotFound();
        return View(parent);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var parent = _context.Parents.Find(id);
        if (parent != null)
        {
            _context.Parents.Remove(parent);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }
}
