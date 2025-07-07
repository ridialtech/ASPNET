using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDiti2025.Data;
using AppDiti2025.Models;

namespace AppDiti2025.Controllers;

public class AdminsController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Admins
    public async Task<IActionResult> Index()
    {
        return View(await _context.Admins.ToListAsync());
    }
}
