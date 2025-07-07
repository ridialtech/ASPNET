using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDiti2025.Data;
using AppDiti2025.Models;

namespace AppDiti2025.Controllers;

public class ApprenantsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ApprenantsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Apprenants
    public IActionResult Index()
    {
        var apprenants = _context.Apprenants.Include(a => a.Parent).ToList();
        return View(apprenants);
    }

    // GET: Apprenants/Details/5
    public IActionResult Details(int? id)
    {
        if (id == null) return NotFound();
        var apprenant = _context.Apprenants
            .Include(a => a.Parent)
            .FirstOrDefault(a => a.IdP == id);
        if (apprenant == null) return NotFound();
        return View(apprenant);
    }

    // GET: Apprenants/Create
    public IActionResult Create()
    {
        ViewData["ParentId"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Parents, "IdPar", "IdPar");
        return View();
    }

    // POST: Apprenants/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("NomP,PrenomP,AdresseP,DateNaissP,SexeP,Matricule,Poids,Taille,ParentId")] Apprenant apprenant)
    {
        if (ModelState.IsValid)
        {
            _context.Add(apprenant);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        ViewData["ParentId"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Parents, "IdPar", "IdPar", apprenant.ParentId);
        return View(apprenant);
    }

    // GET: Apprenants/Edit/5
    public IActionResult Edit(int? id)
    {
        if (id == null) return NotFound();
        var apprenant = _context.Apprenants.Find(id);
        if (apprenant == null) return NotFound();
        ViewData["ParentId"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Parents, "IdPar", "IdPar", apprenant.ParentId);
        return View(apprenant);
    }

    // POST: Apprenants/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("IdP,NomP,PrenomP,AdresseP,DateNaissP,SexeP,Matricule,Poids,Taille,ParentId")] Apprenant apprenant)
    {
        if (id != apprenant.IdP) return NotFound();
        if (ModelState.IsValid)
        {
            _context.Update(apprenant);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        ViewData["ParentId"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Parents, "IdPar", "IdPar", apprenant.ParentId);
        return View(apprenant);
    }

    // GET: Apprenants/Delete/5
    public IActionResult Delete(int? id)
    {
        if (id == null) return NotFound();
        var apprenant = _context.Apprenants
            .Include(a => a.Parent)
            .FirstOrDefault(a => a.IdP == id);
        if (apprenant == null) return NotFound();
        return View(apprenant);
    }

    // POST: Apprenants/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var apprenant = _context.Apprenants.Find(id);
        if (apprenant != null)
        {
            _context.Apprenants.Remove(apprenant);
            _context.SaveChanges();
        }
        return RedirectToAction(nameof(Index));
    }
}
