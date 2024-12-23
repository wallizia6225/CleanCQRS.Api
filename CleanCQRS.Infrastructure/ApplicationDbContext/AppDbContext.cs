using CleanCQRS.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanCQRS.Infrastructure.ApplicationDbContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
