using Managment.System.Domain.Entities.GroupEntities;
using Managment.System.Domain.Entities.ScienceEntities;
using Managment.System.Domain.Entities.StudentEntities;
using Managment.System.Domain.Entities.UserEntities;
using Microsoft.EntityFrameworkCore;

namespace Managment.System.DAL.Data.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentAttendance> StudentAttendaces { get; set; }
    public DbSet<StudentScience> StudentSciences { get; set; }
    public DbSet<StudentTaskResult> StudentTaskResults { get; set; }
    public DbSet<Science> Sciences { get; set; }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<TopicTask> TopicTasks { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
