using Microsoft.EntityFrameworkCore;
namespace MyMovies.Models
{
    public class MyMoviesDbContext : DbContext
    {
        public MyMoviesDbContext(DbContextOptions<MyMoviesDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WatchListMovies>()
                .HasOne(w => w.WatchList)
                .WithMany(wm => wm.WatchListMovies)
                .HasForeignKey(wi => wi.WatchListId);

            modelBuilder.Entity<WatchListMovies>()
                .HasOne(m => m.Movie)
                .WithMany(wm => wm.WatchListMovies)
                .HasForeignKey(mi => mi.MovieId);

            modelBuilder.Entity<WatchListMovies>().HasKey(x => new { x.WatchListId, x.MovieId });
        }

        public DbSet<Movie> Movies => Set<Movie>();
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Mpaa> Mpaas => Set<Mpaa>();
        public DbSet<WatchList> WatchLists => Set<WatchList>();


        public DbSet<WatchListMovies> WatchListMovies => Set<WatchListMovies>();


    }
}