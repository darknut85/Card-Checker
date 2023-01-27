using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class DataContext : DbContext
    {
        public DbSet<Set> Sets { get; set; }
        public DbSet<Card> Cards { get; set; }

        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>().HasData(
                new Card { Id = 1, Name = "Blue-Eyes White Dragon", Number = 1, Owned = false, SetId = 1}
                );

            modelBuilder.Entity<Set>().HasData(
                new Set { Id = 1, Name = "Legend of Blue-Eyes White Dragon", OwnedCards = 1, TotalCards = 126}
                );
        }
    }
}
