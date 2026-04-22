using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Web_Server_Game_Guide.Models;

namespace YourProjectNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}