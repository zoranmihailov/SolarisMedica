using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class Patient
{
    public int Id { get; set; }
    [Required]
    [DisplayName("Име")]
    public string Name { get; set; }
    [Required]
    [DisplayName("Презиме")]
    public string Surname { get; set; }
    
    [DisplayName("Датум на раѓање")]
    public DateTime BirthDate { get; set; }
 
    public string ApplicationUserId { get; set; }
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }
 
    public ICollection<Termin> Termini { get; set; } = new List<Termin>();
}