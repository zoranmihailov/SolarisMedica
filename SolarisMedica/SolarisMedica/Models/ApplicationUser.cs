using Microsoft.AspNetCore.Identity;

namespace SolarisMedica.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}