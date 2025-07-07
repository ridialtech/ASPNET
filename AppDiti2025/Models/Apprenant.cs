using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AppDiti2025.Models;

public class Apprenant : Personne
{
    [Required]
    public string Matricule { get; set; } = string.Empty;

    public float Poids { get; set; }
    public float Taille { get; set; }

    public string UtilisateurId { get; set; } = string.Empty;
    public IdentityUser? Utilisateur { get; set; }

    public int? ParentId { get; set; }
    public Parent? Parent { get; set; }

    public ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
}
