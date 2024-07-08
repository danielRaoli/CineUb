using CineUb.API.Core.Model;
using Microsoft.EntityFrameworkCore;

namespace CineUb.API.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)").HasPrecision(18, 2);
            });


        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<CineSection> Sections { get; set; }
        public DbSet<CineRoom> Rooms { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
