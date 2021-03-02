using System;
using ThingsWeNeed.DataLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace ThingsWeNeed.DataLogic
{
    public class ThingsWeNeedContext : DbContext
    {
        public ThingsWeNeedContext(DbContextOptions<ThingsWeNeedContext> opt) : base(opt) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            var things = modelBuilder.Entity<Thing>();
            
            things.HasKey(p => new { p.Id });

            things.Property(p => p.Needed)
                .IsRequired();

            things.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(40);
        }

        public DbSet<Thing> Things { get; set; }
    }
}
