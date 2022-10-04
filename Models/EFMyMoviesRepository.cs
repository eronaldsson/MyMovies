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


        //Get collection from database
        public IQueryable<Movie>? Movies => context.Movies
            .Include(g => g.Genre)
            .Include(m => m.Mpaa);

        public IQueryable<WatchList>? GetWatchLists => context.WatchLists;

        public IQueryable<WatchListMovies>? WatchListMoviestList => context.WatchListMovies.Include(a => a.Movie).Include(a => a.WatchList);


        //Get length from database
        public int? GetWatchListLength => context.WatchLists.Count();


        //Add to database
        public void AddMovieToWatchList(int movieId)
        {
            context.WatchListMovies.Add(new WatchListMovies { MovieId = movieId, WatchListId = 1 });

            context.SaveChanges();
        }

        public void AddWatchList(string Title, string Creator)
        {
            context.Add(new WatchList
            {
                Title = Title,
                Creator = Creator
            });

            context.SaveChanges();
        }
    }
}
