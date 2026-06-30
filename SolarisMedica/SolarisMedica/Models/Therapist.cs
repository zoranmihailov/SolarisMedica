using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class Therapist
{
    public int Id { get; set; }
    [Required]
    [DisplayName("Име")]
    public string Name { get; set; }
    [Required]
    [DisplayName("Презиме")]
    public string Surname { get; set; }
    [DisplayName("Биографија")]
    public string? Bio { get; set; }
    public string? ProfileImgUrl { get; set; }
    
    
    public string ApplicationUserId { get; set; }
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }
 
    public ICollection<ServiceInTherapist> ServiceInTherapists { get; set; } = new List<ServiceInTherapist>();
    public ICollection<Shift> Shifts { get; set; } = new List<Shift>();
    public ICollection<Termin> Termini { get; set; } = new List<Termin>();
}