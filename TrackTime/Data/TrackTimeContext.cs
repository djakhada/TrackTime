using Microsoft.EntityFrameworkCore;
using System;
using TrackTime.Models;

namespace TrackTime.Data
{
    public class TrackTimeContext : DbContext
    {
        public DbSet<Process> Processes { get; set; }
        public DbSet<ProcessAlias> ProcessAliases { get; set; }
        public string DbPath { get; }

        public TrackTimeContext()
        {
            var folder = Environment.CurrentDirectory;
            DbPath = System.IO.Path.Join(folder, "tracktime.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
