using Entities.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DataContext :DbContext
    {
      //  public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GV7I3N2\\SQLEXPRESS02;Database=Team; Trusted_Connection=True; MultipleActiveResultSets=true;");
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // one to one
            modelBuilder.Entity<Coach>()
                .HasOne(a => a.Team)
                .WithOne(b => b.Coach)
                .HasForeignKey<Coach>(b => b.TeamId);

            //one-to-many
            modelBuilder.Entity<Player>()
               .HasOne(a => a.Team)
               .WithMany(b => b.Players)
               .HasForeignKey(a => a.TeamId)
               .OnDelete(DeleteBehavior.NoAction);



        }
    }
}
