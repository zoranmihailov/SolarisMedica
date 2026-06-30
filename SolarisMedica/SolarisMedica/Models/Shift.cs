using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class Shift
{
    public int Id { get; set; }
 
    public int TherapistId { get; set; }
    [ValidateNever]
    public Therapist Therapist { get; set; }
 
    [DisplayName("Датум")]
    public DateTime Date { get; set; }
 
    [DisplayName("Почеток")]
    public TimeSpan Start { get; set; }
 
    [DisplayName("Крај")]
    public TimeSpan End { get; set; }
}