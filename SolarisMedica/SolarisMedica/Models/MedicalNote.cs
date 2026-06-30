using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class MedicalNote
{
    public int Id { get; set; }
 
    [Required]
    [DisplayName("Белешка")]
    public string Note { get; set; }
 
    [DisplayName("Датум на внес")]
    public DateTime DateCreated { get; set; } = DateTime.Now;
 
    public int TerminId { get; set; }
    [ValidateNever]
    public Termin Termin { get; set; }
}