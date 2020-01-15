using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.DataAccess
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User { Name = "Aslan", About = "Some data" });

            modelBuilder.Entity<Projects>().HasData(
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" },
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" },
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" },
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" },
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" },
                new Projects { Name = "Site", Description = "Some data", ImageUrl = "https://www.6i.com.br/img/img-desenvolvimento-de-sites-1.png" });
        }
    }
}
