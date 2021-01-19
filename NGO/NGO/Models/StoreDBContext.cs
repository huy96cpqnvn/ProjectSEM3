using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NGO.Models
{
    public class StoreDBContext : IdentityDbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Donate> Donates { get; set; }
        public DbSet<Gallery>  Galleries { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Programme> Programmes { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Ngo> Ngos { get; set; }
    }
}
