using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppDiti2025.Data;

using AppDiti2025.Models;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Parent> Parents => Set<Parent>();
    public DbSet<Apprenant> Apprenants => Set<Apprenant>();
    public DbSet<Classe> Classes => Set<Classe>();
    public DbSet<AnneeAcademique> AnneesAcademiques => Set<AnneeAcademique>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Inscription> Inscriptions => Set<Inscription>();
}

