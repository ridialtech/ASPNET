using System.ComponentModel.DataAnnotations;

namespace AppDiti2025.Models;

public class Inscription
{
    [Key]
    public int Id { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateInscription { get; set; }

    public string Statut { get; set; } = string.Empty;

    public int ApprenantId { get; set; }
    public Apprenant Apprenant { get; set; } = null!;

    public int ClasseId { get; set; }
    public Classe Classe { get; set; } = null!;

    public int AnneeAcademiqueId { get; set; }
    public AnneeAcademique AnneeAcademique { get; set; } = null!;

    public int ServiceId { get; set; }
    public Service Service { get; set; } = null!;
}
