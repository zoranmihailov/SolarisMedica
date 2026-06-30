using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class Review
{
    public int Id { get; set; }
 
    [Range(1, 5)]
    [DisplayName("Оцена")]
    public int Ocena { get; set; }
 
    [DisplayName("Коментар")]
    public string? Komentar { get; set; }
 
    [DisplayName("Датум")]
    public DateTime DatePosted { get; set; } = DateTime.Now;
 
    public int TerminId { get; set; }
    [ValidateNever]
    public Termin Termin { get; set; }
}