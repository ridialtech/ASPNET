using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public abstract class Personne
{
    [Key]
    public int IdP { get; set; }

    [Required]
    public string NomP { get; set; } = string.Empty;

    [Required]
    public string PrenomP { get; set; } = string.Empty;

    public string? AdresseP { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateNaissP { get; set; }

    public char SexeP { get; set; }
}
