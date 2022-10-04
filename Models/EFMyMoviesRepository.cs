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

        public IQueryable<WatchListMovies>? GetWatchListMoviestListWithInfo(int watchListId)
        {
            return context.WatchListMovies
            .Where(watchListMovie => watchListMovie.WatchListId == watchListId)
            .Include(watchListMovie => watchListMovie.WatchList)
            .Include(watchListMovie => watchListMovie.Movie)
                .ThenInclude(movie => movie.Genre)
            .Include(watchListMovie => watchListMovie.Movie)
                .ThenInclude(movie => movie.Mpaa);
        }

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
