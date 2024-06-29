namespace BackendAPI_Template.Models
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TabA> TabA { get; set; }
        public DbSet<TabB> TabB { get; set; }
    }
}
