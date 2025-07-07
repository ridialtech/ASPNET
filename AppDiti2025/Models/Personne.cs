using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public abstract class Personne
{
    public int Id { get; set; }

    [Required]
    public string Nom { get; set; } = string.Empty;

    [Required]
    public string Prenom { get; set; } = string.Empty;
}
