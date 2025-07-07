using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public abstract class Utilisateur : Personne
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string? Telephone { get; set; }
}
