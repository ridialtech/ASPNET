using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public class AnneeAcademique
{
    [Key]
    public int IdAA { get; set; }

    public string Designation { get; set; } = string.Empty;

    public ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
}
