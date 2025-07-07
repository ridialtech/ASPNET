using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public class Service
{
    [Key]
    public int IdServ { get; set; }

    public string NomServ { get; set; } = string.Empty;
    public string Option { get; set; } = string.Empty;
    public decimal MontantInscription { get; set; }
    public decimal MontantMensuel { get; set; }

    public ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
}
