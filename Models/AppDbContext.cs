using Microsoft.EntityFrameworkCore;

namespace JokeApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Joke> Jokes { get; set; }
    }
}
