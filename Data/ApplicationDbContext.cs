using JKLHealthcareSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace JKLHealthcareSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Caregiver> Caregivers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
