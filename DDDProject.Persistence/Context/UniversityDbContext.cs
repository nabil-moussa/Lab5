using DDDProject.Domain;

namespace DDDProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;

public class UniversityDbContext:DbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<TimeSlot> TimeSlots { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Admin> Admins { get; set; }

    public UniversityDbContext(DbContextOptions<UniversityDbContext> options)
        : base(options)
    {
    }
}