using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDiti2025.Data;
using AppDiti2025.Models;

namespace AppDiti2025.Controllers;

public class ClientsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ClientsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Clients
    public async Task<IActionResult> Index()
    {
        return View(await _context.Clients.ToListAsync());
    }
}
