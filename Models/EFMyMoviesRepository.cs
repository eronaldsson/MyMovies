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

        public IQueryable<long>? GetMovieIds(int WatchListId)
        {
            return context.WatchListMovies.Where(x => x.WatchListId == WatchListId).Select(x => x.MovieId);
        }

        //Get length from database
        public int? GetWatchListLength => context.WatchLists.Count();


        //Add to database
        public void AddMovieToWatchList(int watchListId, int movieId)
        {
            context.WatchListMovies.Add(new WatchListMovies { WatchListId = watchListId, MovieId = movieId });

            context.SaveChanges();
        }

        public void AddWatchList(WatchList watchList)
        {
            context.Add(watchList);

            context.SaveChanges();
        }

        //Update database
        public void UpdateMovieAsWatched(int watchListId, int movieId)
        {
            WatchListMovies watchListMovies = context.WatchListMovies.Single(x => x.WatchListId == watchListId && x.MovieId == movieId);
            watchListMovies.Watched = true;
            context.SaveChanges();
        }

        //Delete from database
        public void DeleteWatchList(int watchListId)
        {
            WatchList watchList = context.WatchLists.Single(x => x.WatchListId == watchListId);
            context.WatchLists.Remove(watchList);
            context.SaveChanges();
        }
    }
}
