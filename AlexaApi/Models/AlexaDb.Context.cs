using Microsoft.EntityFrameworkCore;

namespace AlexaApi.Models
{
    public class AlexaDbContext : DbContext
    {
        public AlexaDbContext(DbContextOptions<AlexaDbContext> options) : base(options) { }

        public DbSet<EmployeeModel> Employees { get; set; }
    }
}

