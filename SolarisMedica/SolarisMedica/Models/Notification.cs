using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SolarisMedica.Models;

public class Notification
{
    public int Id { get; set; }
 
    public string ApplicationUserId { get; set; }
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }
 
    public string Message { get; set; }
 
    public bool Seen { get; set; } = false;
 
    public DateTime DateSent { get; set; } = DateTime.Now;
 
    public string? Link { get; set; }
}