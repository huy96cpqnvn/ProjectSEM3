using Microsoft.EntityFrameworkCore;

namespace Admin.Models
{
    public class StoreDBContext : DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database=ngo;MultipleActiveResultSets=true");
        public DbSet<Donate> Donates { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Ngo> Ngos { get; set; }
    }
}
