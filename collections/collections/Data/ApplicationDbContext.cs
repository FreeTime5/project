using collections.Data.CollectionModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Diagnostics;

namespace collections.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly string connectionString;
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true);
            connectionString = builder.Build().GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
