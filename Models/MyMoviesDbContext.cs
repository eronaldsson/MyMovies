using Microsoft.EntityFrameworkCore;
namespace MyMovies.Models
{
    public class MyMoviesDbContext : DbContext
    {
        public MyMoviesDbContext(DbContextOptions<MyMoviesDbContext> options)
        : base(options) { }
        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Mpaa> Mpaas => Set<Mpaa>();
    }
}