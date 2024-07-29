using Managment.System.Domain.Entities.StudentEntities;
using Microsoft.EntityFrameworkCore;

namespace Managment.System.DAL.Data.Contexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
}
