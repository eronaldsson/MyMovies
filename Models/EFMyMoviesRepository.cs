using Microsoft.EntityFrameworkCore;

namespace MyMovies.Models
{
    public class EFMyMoviesRepository : IMyMoviesRepository
    {
        private MyMoviesDbContext context;

        public EFMyMoviesRepository(MyMoviesDbContext context)
        {
            this.context = context;
        }

        public void AddMovieToWatchList(int movieId)
        {
            context.WatchListMovies.Add(new WatchListMovies { MovieId = movieId, WatchListId = 1 });
        }

        public IQueryable<WatchListMovies>? WatchListMoviestList => context.WatchListMovies.Include(a => a.Movie).Include(a => a.WatchList);

        public IQueryable<Movie>? Movies => context.Movies
            .Include(g => g.Genre)
            .Include(m => m.Mpaa);
    }
}
