using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AppDiti2025.Models;

public class Parent
{
    [Key]
    public int IdPar { get; set; }

    public string Statut { get; set; } = string.Empty;

    public string UtilisateurId { get; set; } = string.Empty;
    public IdentityUser? Utilisateur { get; set; }

    public ICollection<Apprenant> Apprenants { get; set; } = new List<Apprenant>();
}
