using ProjectMangerWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectMangerWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Phase> Phases { get; set; }
    }
}
