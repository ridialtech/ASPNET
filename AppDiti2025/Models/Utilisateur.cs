using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public abstract class Utilisateur
{
    [Key]
    public string IdentifiantU { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [EmailAddress]
    public string EmailU { get; set; } = string.Empty;

    public string? TelephoneU { get; set; }
}
