using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public class Classe
{
    [Key]
    public int IdC { get; set; }

    public string DesignationC { get; set; } = string.Empty;
    public string NiveauC { get; set; } = string.Empty;

    public ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
}
