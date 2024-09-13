using HobbyHub.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HobbyHub.Data.Crud
{
    public class Base : DbContext
    {
        private static readonly string? _url = Environment.GetEnvironmentVariable("DB_URL");

        public DbSet<User> Users { get; set; }
        public DbSet<MediaUri> MediaUri { get; set; }
        public DbSet<Request> Request { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_url);
        }
    }
}