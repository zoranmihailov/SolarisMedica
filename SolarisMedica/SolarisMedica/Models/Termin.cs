using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public enum StatusTermin
{
    Zakazan,
    Potvrden,
    Otkazan,
    Zavrsen
}
 
public class Termin
{
    public int Id { get; set; }
 
    [DisplayName("Датум и време")]
    public DateTime DateAndTime { get; set; }
 
    public StatusTermin Status { get; set; } = StatusTermin.Zakazan;
 
    [DisplayName("Цена")]
    public decimal Price { get; set; }
 
    public int TherapistId { get; set; }
    [ValidateNever]
    public Therapist Therapist { get; set; }
 
    public int PatientId { get; set; }
    [ValidateNever]
    public Patient Patient { get; set; }
 
    public int ServiceId { get; set; }
    [ValidateNever]
    public Service Service { get; set; }
 
    [ValidateNever]
    public Review? Review { get; set; }
 
    [ValidateNever]
    public MedicalNote? MedicalNote { get; set; }
}