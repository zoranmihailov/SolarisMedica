using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarisMedica.Models;

namespace SolarisMedica.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Therapist> Therapists { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceInTherapist> ServiceInTherapists { get; set; }
    public DbSet<Termin> Termini { get; set; }
    public DbSet<Shift> Shifts { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<MedicalNote> MedicalNotes { get; set; }
    public DbSet<Notification> Notifications { get; set; }
}