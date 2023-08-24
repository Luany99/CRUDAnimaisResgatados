using Animais.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Animais.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IAH94IU\SQLEXPRESS;Trusted_connection=true; Database=Animais; TrustServerCertificate=True;");
        }
        public DbSet<AnimaisModels> AnimaisModels { get; set; }

    }
}
