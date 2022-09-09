using Microsoft.EntityFrameworkCore;
namespace MyMovies.Models
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
        : base(options) { }
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Mpaa> Mpaas => Set<Mpaa>();
    }
}