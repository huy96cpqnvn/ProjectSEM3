using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NGO.Models
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
        public DbSet<Gallery>  Galleries { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Ngo> Ngos { get; set; }
    }
}
