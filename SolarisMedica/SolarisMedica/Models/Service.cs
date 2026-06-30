using System.ComponentModel.DataAnnotations;

namespace SolarisMedica.Models;

public class Service
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int Duration { get; set; }
    
    [Range(1, 20)]
    public int NumMachines { get; set; } = 1;
 
    public ICollection<ServiceInTherapist> ServiceInTherapists { get; set; } = new List<ServiceInTherapist>();
    public ICollection<Termin> Termini { get; set; } = new List<Termin>();
}