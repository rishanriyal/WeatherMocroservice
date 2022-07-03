﻿using Microsoft.EntityFrameworkCore;

namespace CloudWeather.Temperature.DataAccess
{
    public class TempDbContext : DbContext
    {
        public TempDbContext() { }
        public TempDbContext(DbContextOptions opts) : base(opts) { }

        public DbSet<Temperature> Temperature { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTableNames(modelBuilder);
        }

        private static void SnakeCaseIdentityTableNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Temperature>(b => { b.ToTable("temperature"); });
        }
    }
}
