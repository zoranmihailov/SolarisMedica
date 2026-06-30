using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class ServiceInTherapist
{
    public int Id { get; set; }
    public int TherapistId { get; set; }
    [ValidateNever]
    public Therapist Therapist { get; set; }
 
    public int ServiceId { get; set; }
    [ValidateNever]
    public Service Service { get; set; }
}