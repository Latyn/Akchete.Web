using System;
using Microsoft.Data.Entity;
using AK.Models;
using AK;

namespace Ak.Models
{
    public class WorldContext : DbContext
    {
        public WorldContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Event> Events{get; set;}
        public DbSet<MusicGroup> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

            var connString = Startup.Configuration["Data:WorldContextConnection"];
            optionBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionBuilder);
        }

    }
}